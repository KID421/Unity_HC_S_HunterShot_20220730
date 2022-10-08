// 單行註解
using UnityEngine;  // 引用 Unity 遊戲引擎命名空間：倉庫實用資料與功能

// 腳本 = 類別
/*
 * 多行註解
 * 多行註解
 */

namespace KID
{
    // Unity 類別要執行必須放在遊戲物件上
    /// <summary>
    /// 摘要：輔助說明並且會出現在編譯器提示上
    /// First Script 第一個腳本學習 C# 基礎與 Unity
    /// </summary>
    public class FirstScript : MonoBehaviour
    {
        #region 資料區域
        // 資料
        // 資料
        // 資料
        #endregion

        #region 事件區域：Unity 入口
        /// <summary>
        /// 喚醒事件：遊戲開始時並且在 Start 前執行一次
        /// </summary>
        private void Awake()
        {
            print("哈囉，沃德 :D");
        }

        /// <summary>
        /// 開始事件：遊戲開始時並且在 Awake 後執行一次
        /// </summary>
        private void Start()
        {
            print("開始事件！");
            // Rich Text
            print("<color=yellow>黃色文字</color>");
            print("<color=#006699>藍綠色</color>");
        }
        #endregion
    }
}
