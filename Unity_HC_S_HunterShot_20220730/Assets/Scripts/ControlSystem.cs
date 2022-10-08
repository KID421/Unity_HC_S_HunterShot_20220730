using UnityEngine;

namespace KID
{
    /// <summary>
    /// ����t��
    /// </summary>
    public class ControlSystem : MonoBehaviour
    {
        #region ���
        [Header("�򥻸��")]
        [SerializeField, Range(0, 50)]
        private float speed = 10.5f;
        [SerializeField, Range(0, 5000)]
        private int speedMarble = 1500;
        [SerializeField, Range(0, 3)]
        private float intervalShoot = 0.5f;
        [SerializeField]
        private int countShootMarble = 10;

        [SerializeField, Header("�u�]�w�s��")]
        private GameObject prefabMarble;

        private string parAttack = "Ĳ�o����";
        #endregion
    }
}
