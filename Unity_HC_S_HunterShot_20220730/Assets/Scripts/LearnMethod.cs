using UnityEngine;

namespace KID
{
    /// <summary>
    /// 學習方法 Method
    /// </summary>
    public class LearnMethod : MonoBehaviour
    {
        // 方法語法：
        // 修飾詞 傳回資料類型 方法名稱 (參數) { 程式區塊、陳述式、演算法 }

        // 自訂方法：不會執行，需要呼叫
        // VS 2019
        // 方法名稱沒有被呼叫時會淡黃色
        // 方法名稱有被呼叫時會亮黃色
        // 無 void
        private void Test()
        {
            print("我是測試方法~");
        }

        private void Awake()
        {
            // 呼叫方法語法：
            // 方法名稱()；
            Test();
            Test();
        }
    }
}
