using UnityEngine;

namespace KID
{
    /// <summary>
    /// 控制系統
    /// </summary>
    public class ControlSystem : MonoBehaviour
    {
        #region 資料
        [Header("基本資料")]
        [SerializeField, Range(0, 50)]
        private float speed = 10.5f;
        [SerializeField, Range(0, 5000)]
        private int speedMarble = 1500;
        [SerializeField, Range(0, 3)]
        private float intervalShoot = 0.5f;
        [SerializeField]
        private int countShootMarble = 10;

        [SerializeField, Header("彈珠預製物")]
        private GameObject prefabMarble;

        private string parAttack = "觸發攻擊";
        #endregion

        #region 方法
        /// <summary>
        /// 旋轉角色
        /// </summary>
        private void TurnCharacter()
        {

        }

        /// <summary>
        /// 發射彈珠
        /// </summary>
        private void ShootMarble()
        {

        }

        /// <summary>
        /// 生成彈珠
        /// </summary>
        /// <param name="countToSpawn">要生成的彈珠數量</param>
        private void SpawnMarble(int countToSpawn)
        {

        }
        #endregion
    }
}
