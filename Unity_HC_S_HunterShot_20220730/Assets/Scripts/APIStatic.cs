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
            #region 認識 靜態 API
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
            #endregion

            print("所有攝影機數量：" + Camera.allCamerasCount);
            print("圓周率：" + Mathf.PI);

            // 物理.地心引力 = 三維向量；
            Physics.gravity = new Vector3(0, 10, 0);
            // 時間.尺寸 = 時間尺寸值；(預設為 1)
            Time.timeScale = 5;
            // 螢幕.亮度 = 值 (0 ~ 1)
            Screen.brightness = 0.3f;

            // 數學.無條件捨去小數點(數值)
            print("9.99 無條件捨去：" + Mathf.Floor(9.99f));
            // 應用程式.開啟連結("網址");
            Application.OpenURL("https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab_channel=RickAstley");
        }

        private void Update()
        {
            // print("經過時間：" + Time.time);

            // 輸入.按下按鍵(按鍵)
            print("是否按空白鍵：" + Input.GetKeyDown(KeyCode.Space));
        }
    }
}
