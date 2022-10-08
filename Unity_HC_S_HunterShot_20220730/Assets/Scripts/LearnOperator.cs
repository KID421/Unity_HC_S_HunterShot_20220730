using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習運算子：
    /// 1. 數學
    /// 2. 比較
    /// 3. 邏輯
    /// 4. 三元
    /// </summary>
    public class LearnOperator : MonoBehaviour
    {
        private float a = 10, b = 3;

        private void Awake()
        {
            // OperatorMath();
            // OperatorComparison();
            // OperatorLogic();
            OperatorTernary();
        }

        /// <summary>
        /// 數學運算子
        /// </summary>
        private void OperatorMath()
        {
            // 加、減、乘、除、餘
            // +、-、*、/、%
            print("加法：" + (a + b));     // 13
            print("減法：" + (a - b));     // 7
            print("乘法：" + (a * b));     // 30
            print("除法：" + (a / b));     // 3.333
            print("餘法：" + (a % b));     // 1
        }

        /// <summary>
        /// 比較運算子
        /// </summary>
        private void OperatorComparison()
        {
            // 大於、小於、大於等於、小於等於、等於、不等於
            // >、<、>=、<=、==、!=
            // 比較運算子的結果為布林值，是 true、否 false
            print("大　　於：" + (a > b));       // t
            print("小　　於：" + (a < b));       // f
            print("大於等於：" + (a >= b));      // t
            print("小於等於：" + (a <= b));      // f
            print("等　　於：" + (a == b));      // f
            print("不　等於：" + (a != b));      // t
        }

        /// <summary>
        /// 邏輯運算子
        /// </summary>
        private void OperatorLogic()
        {
            // 並且、或者、顛倒
            // &&、||、!
            // 並且：比較兩個布林值
            // 只要其中一個布林值等於 f 結果就是 f
            print(true && true);        // t
            print(true && false);       // f
            print(false && true);       // f
            print(false && false);      // f

            // 或者：比較兩個布林值
            // 只要其中一個布林值等於 t 結果就是 t
            print(true || true);        // t
            print(true || false);       // t
            print(false || true);       // t
            print(false || false);      // f

            // 顛倒：將布林值變相反
            print(!true);               // f
            print(!false);              // t
            print(!(a > b));            // f
        }

        /// <summary>
        /// 三元運算子
        /// </summary>
        private void OperatorTernary()
        {
            // 語法：
            // 布林值 ? 運算式一 : 運算式二；
            // 當布林值為 true 時執行運算式一
            // 當布林值為 false 時執行運算式二
            print(true ? "我是運算式一" : "我是運算式二");
            print((a < b) ? "a 小於 b" : "a 大於 b");
        }
    }
}
