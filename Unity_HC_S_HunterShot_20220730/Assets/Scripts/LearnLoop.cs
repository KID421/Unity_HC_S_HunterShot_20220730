using UnityEngine;

namespace KID
{
    /// <summary>
    /// �ǲ߰j��G�ϴ_�y�y
    /// 1. while
    /// 2. for
    /// 3. �}�C Array
    /// </summary>
    public class LearnLoop : MonoBehaviour
    {
        private int countWhile = 0;

        [SerializeField] private int numberA = 10;
        [SerializeField] private int numberB = 50;
        [SerializeField] private int numberC = 500;

        [SerializeField]
        private int[] numbers;

        private void Awake()
        {
            WhileBase();
            ForBase();

            // ���o�}�C��� Get
            print("�ĤG�ӼƦr���ȡG" + numbers[1]);

            // �s��}�C��� Set
            numbers[2] = 99;
        }

        /// <summary>
        /// while �j���¦
        /// </summary>
        private void WhileBase()
        {
            // ���L�Ȭ� true �ɰ���@��
            if (true)
            {

            }

            // ���L�Ȭ� true �ɫ������
            while (countWhile < 5)
            {
                print("while �j����榸�ơG" + countWhile);
                // countWhile = countWhile + 1;
                countWhile++;
            }
        }

        /// <summary>
        /// for �j���¦
        /// </summary>
        private void ForBase()
        {
            for (int x = 0; x < 5; x++)
            {
                print("<color=yellow>for �j����榸�ơG" + x + "</color>");
            }
        }
    }
}
