using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習迴圈：反復語句
    /// 1. while
    /// 2. for
    /// 3. 陣列 Array
    /// </summary>
    public class LearnLoop : MonoBehaviour
    {
        private int countWhile = 0;

        [SerializeField] private int numberA = 10;
        [SerializeField] private int numberB = 50;
        [SerializeField] private int numberC = 500;

        [SerializeField]
        private int[] numbers;
        [SerializeField]
        private string[] props = { "紅色藥水", "藍色藥水", "黃色藥水" };

        private void Awake()
        {
            WhileBase();
            ForBase();

            // 取得陣列資料 Get
            print("第二個數字的值：" + numbers[1]);

            // 存放陣列資料 Set
            numbers[2] = 99;

            // 陣列數量
            print("道具陣列的數量：" + props.Length);
        }

        /// <summary>
        /// while 迴圈基礎
        /// </summary>
        private void WhileBase()
        {
            // 當布林值為 true 時執行一次
            if (true)
            {

            }

            // 當布林值為 true 時持續執行
            while (countWhile < 5)
            {
                print("while 迴圈執行次數：" + countWhile);
                // countWhile = countWhile + 1;
                countWhile++;
            }
        }

        /// <summary>
        /// for 迴圈基礎
        /// </summary>
        private void ForBase()
        {
            for (int x = 0; x < 5; x++)
            {
                print("<color=yellow>for 迴圈執行次數：" + x + "</color>");
            }

            for (int i = 0; i < props.Length; i++)
            {
                print("道具資料：" + props[i]);
            }
        }
    }
}
