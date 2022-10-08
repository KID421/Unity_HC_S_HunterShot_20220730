using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ǲ߹B��l�G
    /// 1. �ƾ�
    /// 2. ���
    /// 3. �޿�
    /// 4. �T��
    /// </summary>
    public class LearnOperator : MonoBehaviour
    {
        private void Awake()
        {
            // OperatorMath();
            // OperatorComparison();
            OperatorLogic();
        }

        private float a = 10, b = 3;

        /// <summary>
        /// �ƾǹB��l
        /// </summary>
        private void OperatorMath()
        {
            // �[�B��B���B���B�l
            // +�B-�B*�B/�B%
            print("�[�k�G" + (a + b));     // 13
            print("��k�G" + (a - b));     // 7
            print("���k�G" + (a * b));     // 30
            print("���k�G" + (a / b));     // 3.333
            print("�l�k�G" + (a % b));     // 1
        }

        /// <summary>
        /// ����B��l
        /// </summary>
        private void OperatorComparison()
        {
            // �j��B�p��B�j�󵥩�B�p�󵥩�B����B������
            // >�B<�B>=�B<=�B==�B!=
            // ����B��l�����G�����L�ȡA�O true�B�_ false
            print("�j�@�@��G" + (a > b));       // t
            print("�p�@�@��G" + (a < b));       // f
            print("�j�󵥩�G" + (a >= b));      // t
            print("�p�󵥩�G" + (a <= b));      // f
            print("���@�@��G" + (a == b));      // f
            print("���@����G" + (a != b));      // t
        }

        /// <summary>
        /// �޿�B��l
        /// </summary>
        private void OperatorLogic()
        {
            // �åB�B�Ϊ̡B�A��
            // &&�B||�B!
            // �åB�G�����ӥ��L��
            // �u�n�䤤�@�ӥ��L�ȵ��� f ���G�N�O f
            print(true && true);        // t
            print(true && false);       // f
            print(false && true);       // f
            print(false && false);      // f

            // �Ϊ̡G�����ӥ��L��
            // �u�n�䤤�@�ӥ��L�ȵ��� t ���G�N�O t
            print(true || true);        // t
            print(true || false);       // t
            print(false || true);       // t
            print(false || false);      // f

            // �A�ˡG�N���L���ܬۤ�
            print(!true);               // f
            print(!false);              // t
            print(!(a > b));            // f
        }
    }
}
