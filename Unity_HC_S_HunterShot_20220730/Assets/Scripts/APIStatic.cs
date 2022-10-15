using UnityEngine;

namespace KID
{
    /// <summary>
    /// �{�� �R�A Static API
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
        private void Awake()
        {
            // �R�A API
            // 1. �R�A�ݩ� Static Properties

            // 1-1 ���o Get
            // �y�k�G
            // ���O�W��.�R�A�ݩ�
            
            print("�H���ȡG" + Random.value);

            print("���ε{���O�_���椤�G" + Application.isPlaying);

            // 1-2 �s�� Set
            // �y�k�G
            // ���O�W��.�R�A�ݩ� ���w �ȡF

            // Application.isPlaying = false; // Read Only ��Ū�ݩʡG����s��
            
            // ���ε{��.�O�_�b�I���B�� = ���L�ȡF
            Application.runInBackground = false;
            // �ƹ�����.�i���� = ��_�ݨ��F
            Cursor.visible = false;

            // 2. �R�A��k Static Methods
            // �y�k�G
            // ���O�W��.�R�A��k(�����޼�)�F

            // �H��.�d��(�̤p�ȡA�̤j��)
            float range =  Random.Range(3.5f, 9.9f);
            print("�H���d�򤶩� 3.5 ~ 9.9�G" + range);

            // �ƾ�.�����(�ƭ�)
            float abs = Mathf.Abs(-99.5f);
            print("-99.5 ����ȵ��G�G" + abs);
        }

        private void Update()
        {
            
        }
    }
}
