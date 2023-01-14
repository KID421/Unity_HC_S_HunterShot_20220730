using UnityEngine;
using UnityEngine.Events;

namespace KID
{
    /// <summary>
    /// 回合系統
    /// </summary>
    public class TurnSystem : MonoBehaviour
    {
        [Header("敵人回合事件")]
        public UnityEvent onEnemyTurn;

        [SerializeField, Header("敵人回合多久生成下一波"), Range(0, 3)]
        private float timeToSpawnNextEnemy = 1.2f;
        [SerializeField, Header("生成後多久回到玩家回合"), Range(0, 3)]
        private float timeToPlayerTurn = 0.8f;

        private SpawnSystem spawnSystem;

        #region 資料
        public enum Turn { Player, Enemy }
        [SerializeField]
        private Turn turn;

        private string nameMarble = "彈珠";
        private int countRecycleMarble;
        private ControlSystem controlSystem; 
        #endregion

        private void Awake()
        {
            controlSystem = FindObjectOfType<ControlSystem>();
            spawnSystem = FindObjectOfType<SpawnSystem>();
        }

        private void OnTriggerEnter(Collider other)
        {
            if (other.name.Contains(nameMarble))
            {
                RecycleMarble();
            }
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
            Invoke("SpawnNextEnemy", timeToSpawnNextEnemy);     // 延遲呼叫("方法名稱"，延遲時間)
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
        }
    }
}
