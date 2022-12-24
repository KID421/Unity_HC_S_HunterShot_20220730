using UnityEngine;
using System.Collections;
using TMPro;
using UnityEngine.UI;

namespace KID
{
    /// <summary>
    /// 傷害系統：產生傷害值物件、更新傷害值與動畫效果
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("畫布傷害值")]
        private GameObject prefabDamage;
        [SerializeField, Header("傷害值位移")]
        private Vector3 offsetDamage;
        [SerializeField, Header("資料")]
        private DataEnemy dataEnemy;
        [SerializeField, Header("動畫控制器")]
        private Animator ani;
        [SerializeField, Header("血條")]
        private Image imgHp;
        [SerializeField, Header("文字血量")]
        private TextMeshProUGUI textHp;

        private float hp;
        private float hpMax;
        private string parDamage = "觸發受傷";
        private string nameMarble = "彈珠";
        private TextMeshProUGUI textDamage;
        private PlayerData playerData;
        #endregion

        #region 事件
        private void Awake()
        {
            hp = dataEnemy.hp;
            hpMax = hp;
            UpdateUI();

            // SpawnDamageObject();
            playerData = GameObject.Find("小藍").GetComponent<PlayerData>();
        }

        // 碰撞開始事件：兩個物件碰撞時執行一次
        private void OnCollisionEnter(Collision collision)
        {
            // print("碰到的物件：" + collision.gameObject);

            // 如果 碰撞.物件.名稱 包含(彈珠) 就 生成傷害物件
            if (collision.gameObject.name.Contains(nameMarble))
            {
                SpawnDamageObject();
            }
        }

        // 碰撞離開事件：兩個物件碰撞結束執行一次
        private void OnCollisionExit(Collision collision)
        {

        }

        // 碰撞持續事件：兩個物件碰撞器重疊時持續執行
        private void OnCollisionStay(Collision collision)
        {

        } 
        #endregion

        /// <summary>
        /// 生成傷害值物件
        /// </summary>
        private void SpawnDamageObject()
        {
            GameObject tempDamage = Instantiate(
                prefabDamage,
                transform.position + offsetDamage,
                Quaternion.Euler(50, 0, 0));

            textDamage = tempDamage.transform.Find("文字傷害值").GetComponent<TextMeshProUGUI>();
            float attack = playerData.attack;
            textDamage.text = "-" + attack;
            Damage(attack);

            StartCoroutine(AnimationEffect(tempDamage));
        }

        /// <summary>
        /// 受傷
        /// </summary>
        /// <param name="attack">接收到的攻擊力</param>
        private void Damage(float attack)
        {
            hp -= attack;
            ani.SetTrigger(parDamage);
            UpdateUI();

            if (hp <= 0) Dead();
        }

        /// <summary>
        /// 死亡
        /// </summary>
        private void Dead()
        {
            hp = 0;
            // 刪除(物件)；
            // gameObject 此遊戲物件
            Destroy(gameObject);
        }

        /// <summary>
        /// 更新介面
        /// </summary>
        private void UpdateUI()
        {
            textHp.text = hp.ToString();
            imgHp.fillAmount = hp / hpMax;
        }

        /// <summary>
        /// 動畫效果
        /// </summary>
        /// <param name="tempDamage">傷害值物件</param>
        private IEnumerator AnimationEffect(GameObject tempDamage)
        {
            StartCoroutine(Fade(tempDamage.GetComponent<CanvasGroup>()));
            
            yield return StartCoroutine(MoveDamage(tempDamage.GetComponent<RectTransform>()));

            yield return StartCoroutine(MoveDamage(tempDamage.GetComponent<RectTransform>(), false, 3));

            StartCoroutine(Fade(tempDamage.GetComponent<CanvasGroup>(), false));
        }

        /// <summary>
        /// 移動傷害值效果
        /// </summary>
        /// <param name="rectDamage">傷害值變形元件</param>
        private IEnumerator MoveDamage(RectTransform rectDamage, bool isUp = true, int count = 10)
        {
            float increase = isUp ? +0.1f : -0.1f;

            for (int i = 0; i < count; i++)
            {
                rectDamage.anchoredPosition += new Vector2(0, increase);
                yield return new WaitForSeconds(0.03f);
            }
        }

        /// <summary>
        /// 淡入淡出
        /// </summary>
        /// <param name="group">群組元件</param>
        /// <param name="fadeIn">是否淡入</param>
        private IEnumerator Fade(CanvasGroup group, bool fadeIn = true)
        {
            // 三元運算子
            // 布林值 ? 布林值為 true : 布林值為 false;
            float increase = fadeIn ? +0.1f : -0.1f;    // 如果 淡入 就增加 +0.1 否則 -0.1

            for (int i = 0; i < 10; i++)
            {
                group.alpha += increase;                // 群組元件的透明度 遞增
                yield return new WaitForSeconds(0.03f);
            }
        }
    }
}
