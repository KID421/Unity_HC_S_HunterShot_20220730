using UnityEngine;
using System.Collections;

namespace KID
{
    /// <summary>
    /// 傷害系統：產生傷害值物件、更新傷害值與動畫效果
    /// </summary>
    public class DamageSystem : MonoBehaviour
    {
        [SerializeField, Header("畫布傷害值")]
        private GameObject prefabDamage;
        [SerializeField, Header("傷害值位移")]
        private Vector3 offsetDamage;

        private void Awake()
        {
            SpawnDamageObject();
        }

        /// <summary>
        /// 生成傷害值物件
        /// </summary>
        private void SpawnDamageObject()
        {
            GameObject tempDamage = Instantiate(
                prefabDamage,
                transform.position + offsetDamage,
                Quaternion.Euler(50, 0, 0));

            StartCoroutine(AnimationEffect(tempDamage));
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
