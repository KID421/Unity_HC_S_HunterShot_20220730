using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ǲ߫D�R�A API
    /// Properties
    /// Public Methods
    /// </summary>
    public class APINonStatic : MonoBehaviour
    {
        // �R�A�Gstatic �s�b�O���餺�A��C������S�����Y
        // Time�BRandom

        // �D�R�A�G�w�]���s�b�O���餺�A��C���������Y
        // Transform

        // 1. �D�R�A�ݩ� Properties

        // 1-1 ���o Get
        // �y�k�G
        // �B�J�@�G�w�q����x�s�C������
        // ���W��.�D�R�A�ݩ�

        // �B�J�G�G�T�w�Ӫ��󦳦�����
        // �Ҧp�G�O�� Light

        public Transform traA;
        public Light lightA;

        public Transform traPlayer;
        public Camera camMain;

        public Transform traBat;

        // 1-2 �]�w Set
        // �y�k�G
        // ���W��.�D�R�A�ݩ� ���w �ȡF

        // 2. �D�R�A��k Pulic Methods
        // �y�k�G
        // ���W��.�D�R�A��k(�������޼�)�F

        private void Awake()
        {
            print("�y�СG" + traA.position);
            print("�O���C��G" + lightA.color);

            // ��Ū�ݩʤ���]�w
            // traPlayer.lossyScale = Vector3.one * 10;

            traPlayer.localScale = Vector3.one * 10;

            camMain.depth = 7;
            print("��v���`�סG" + camMain.depth);
        }

        private void Update()
        {
            traBat.Rotate(0, 30, 0);
        }
    }
}
