using UnityEngine;
using System.Linq;
using System.Collections.Generic;

namespace KID
{
    /// <summary>
    /// 生成系統
    /// </summary>
    public class SpawnSystem : MonoBehaviour
    {
        #region 資料
        [SerializeField, Header("怪物預製物")]
        private GameObject[] prefabEnemys;
        [SerializeField, Header("怪物生成第二排")]
        private Transform[] traSpawnPoints;
        [Header("生成數量：最小與最大值")]
        [SerializeField]
        private int minEnemy = 2;
        [SerializeField]
        private int maxEnemy = 5;
        [SerializeField, Header("第二排的格子清單")]
        private List<Transform> listSpawnPoints = new List<Transform>();
        #endregion

        #region 事件
        private void Awake()
        {
            SpawnEnemy();
        }
        #endregion

        #region 方法
        /// <summary>
        /// 生成敵人
        /// </summary>
        private void SpawnEnemy()
        {
            int randomCount = Random.Range(minEnemy, maxEnemy + 1);
            print("<color=#3366aa>敵人隨機數量：" + randomCount + "</color>");

            int countToDelete = traSpawnPoints.Length - randomCount;
            print("<color=#aa6633>要刪除的數量：" + countToDelete + "</color>");

            // 清單 = 陣列.轉為清單()；
            listSpawnPoints = traSpawnPoints.ToList();

            // 系統.隨機 隨機 = 新 隨機物件；
            System.Random random = new System.Random();
            // 生成清單 = 生成清單.排序(每一個清單 => 亂數排序).轉回清單
            listSpawnPoints = listSpawnPoints.OrderBy(item => random.Next()).ToList();

            // 透過迴圈刪除清單第一筆
            for (int i = 0; i < countToDelete; i++) listSpawnPoints.RemoveAt(0);

            for (int i = 0; i < randomCount; i++)
            {
                int randomEnemy = Random.Range(0, prefabEnemys.Length);
                Vector3 pos = listSpawnPoints[i].position;
                Instantiate(prefabEnemys[randomEnemy], pos, Quaternion.identity);
            }
        }
        #endregion
    }
}
