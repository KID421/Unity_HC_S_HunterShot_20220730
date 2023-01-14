using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using TMPro;
using System.Collections;

namespace KID
{
    /// <summary>
    /// 回合系統
    /// </summary>
    public class TurnSystem : MonoBehaviour
    {
        private TextMeshProUGUI textFinalTitle;
        private Button btnReplay, btnQuit;
        private CanvasGroup groupFinal;

        #region 資料
        [Header("敵人回合事件")]
        public UnityEvent onEnemyTurn;

        [SerializeField, Header("敵人回合多久生成下一波"), Range(0, 3)]
        private float timeToSpawnNextEnemy = 1.2f;
        [SerializeField, Header("生成後多久回到玩家回合"), Range(0, 3)]
        private float timeToPlayerTurn = 0.8f;
        [SerializeField, Header("最大層數")]
        private int countFloorMax = 5;

        /// <summary>
        /// 層數數字
        /// </summary>
        private TextMeshProUGUI textFloorCount;
        private int countFloor = 1;

        public enum Turn { Player, Enemy }
        [SerializeField]
        private Turn turn;

        private SpawnSystem spawnSystem;
        private string nameMarble = "彈珠";
        private int countRecycleMarble;
        private ControlSystem controlSystem; 
        #endregion

        private void Awake()
        {
            controlSystem = FindObjectOfType<ControlSystem>();
            spawnSystem = FindObjectOfType<SpawnSystem>();

            textFloorCount = GameObject.Find("層數數字").GetComponent<TextMeshProUGUI>();

            textFinalTitle = GameObject.Find("結束標題").GetComponent<TextMeshProUGUI>();
            btnReplay = GameObject.Find("重新挑戰").GetComponent<Button>();
            btnQuit = GameObject.Find("離開遊戲").GetComponent<Button>();
            groupFinal = GameObject.Find("結束畫面").GetComponent<CanvasGroup>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameMarble))
            {
                RecycleMarble();
            }
        }

        /// <summary>
        /// 淡入結束畫面
        /// </summary>
        /// <param name="title">要更新的標題</param>
        public void FadeInFinal(string title)
        {
            textFinalTitle.text = title;
            StartCoroutine(Fade());
        }

        private IEnumerator Fade()
        {
            for (int i = 0; i < 10; i++)
            {
                groupFinal.alpha += 0.1f;
                yield return new WaitForSeconds(0.02f);
            }

            groupFinal.interactable = true;                     // 畫布群組元件.互動 = 勾選 - 可互動
            groupFinal.blocksRaycasts = true;                   // 畫布群組元件.遮擋 = 勾選 - 可被滑鼠選取
        }

        /// <summary>
        /// 回收彈珠
        /// </summary>
        private void RecycleMarble()
        {
            countRecycleMarble++;

            if (countRecycleMarble == controlSystem.countShootMarble)
            {
                EnemyTurn();
            }
        }

        /// <summary>
        /// 敵人回合
        /// </summary>
        private void EnemyTurn()
        {
            turn = Turn.Enemy;
            onEnemyTurn.Invoke();                               // 事件.呼叫()； - 讓事件執行

            if (countFloor < countFloorMax)
                Invoke("SpawnNextEnemy", timeToSpawnNextEnemy); // 延遲呼叫("方法名稱"，延遲時間)
            else
                Invoke("PlayerTurn", timeToPlayerTurn);
        }

        /// <summary>
        /// 生成下一波敵人
        /// </summary>
        private void SpawnNextEnemy()
        {
            spawnSystem.SpawnEnemy();
            Invoke("PlayerTurn", timeToPlayerTurn);
        }

        /// <summary>
        /// 玩家回合
        /// </summary>
        private void PlayerTurn()
        {
            turn = Turn.Player;
            countRecycleMarble = 0;
            controlSystem.isShooted = false;

            controlSystem.countShootMarble += controlSystem.addMarbleThisTurn;
            controlSystem.addMarbleThisTurn = 0;

            if (countFloor < countFloorMax)
            {
                countFloor++;                                   // 層數遞增
                textFloorCount.text = countFloor.ToString();    // 層數文字更新
            }
        }
    }
}
