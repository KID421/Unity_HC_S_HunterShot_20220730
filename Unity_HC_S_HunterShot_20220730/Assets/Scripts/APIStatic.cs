using UnityEngine;

namespace KID
{
    /// <summary>
    /// 認識 靜態 Static API
    /// </summary>
    public class APIStatic : MonoBehaviour
    {
        private void Awake()
        {
            // 靜態 API
            // 1. 靜態屬性 Static Properties

            // 1-1 取得 Get
            // 語法：
            // 類別名稱.靜態屬性
            
            print("隨機值：" + Random.value);

            print("應用程式是否執行中：" + Application.isPlaying);

            // 1-2 存放 Set
            // 語法：
            // 類別名稱.靜態屬性 指定 值；

            // Application.isPlaying = false; // Read Only 唯讀屬性：不能存放
            
            // 應用程式.是否在背景運行 = 布林值；
            Application.runInBackground = false;
            // 滑鼠指標.可視性 = 能否看見；
            Cursor.visible = false;

            // 2. 靜態方法 Static Methods
            // 語法：
            // 類別名稱.靜態方法(對應引數)；

            // 隨機.範圍(最小值，最大值)
            float range =  Random.Range(3.5f, 9.9f);
            print("隨機範圍介於 3.5 ~ 9.9：" + range);

            // 數學.絕對值(數值)
            float abs = Mathf.Abs(-99.5f);
            print("-99.5 絕對值結果：" + abs);
        }

        private void Update()
        {
            
        }
    }
}
