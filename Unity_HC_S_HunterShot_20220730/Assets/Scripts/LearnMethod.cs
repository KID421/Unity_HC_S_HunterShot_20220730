using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ǲߤ�k Method
    /// </summary>
    public class LearnMethod : MonoBehaviour
    {
        // ��k�y�k�G
        // �׹��� �Ǧ^������� ��k�W�� (�Ѽ�) { �{���϶��B���z���B�t��k }

        // �ۭq��k�G���|����A�ݭn�I�s
        // VS 2019
        // ��k�W�٨S���Q�I�s�ɷ|�H����
        // ��k�W�٦��Q�I�s�ɷ|�G����
        // �L void
        private void Test()
        {
            print("�ڬO���դ�k~");
        }

        private void Awake()
        {
            // �I�s��k�y�k�G
            // ��k�W��()�F
            Test();
            Test();
        }
    }
}
