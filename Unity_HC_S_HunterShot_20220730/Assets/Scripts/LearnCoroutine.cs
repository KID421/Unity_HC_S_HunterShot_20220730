using UnityEngine;
using System.Collections;

namespace KID
{
    /// <summary>
    /// 學習協同程序
    /// </summary>
    public class LearnCoroutine : MonoBehaviour
    {
        // ※ 讓程式等待
        // 1. 引用 系統集合 命名空間
        // 2. 定義傳回 IEnumerator 的方法
        // 3. 使用 StartCoroutine 啟動

        private void Awake()
        {
            StartCoroutine(Test());
        }

        private IEnumerator Test()
        {
            print("第一段程式");
            yield return new WaitForSeconds(2);
            print("兩秒後執行，第二段程式");
            yield return new WaitForSeconds(3);
            print("三秒後執行，第三段程式");
        }
    }
}
