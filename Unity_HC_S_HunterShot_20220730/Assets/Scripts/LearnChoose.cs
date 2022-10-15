using UnityEngine;

namespace KID
{
    /// <summary>
    /// 選取語句：
    /// 1. if
    /// 2. switch
    /// 3. 列舉 enumeration
    /// </summary>
    public class LearnChoose : MonoBehaviour
    {
        [SerializeField]
        private int keyCount;
        [SerializeField]
        private int score = 0;
        [SerializeField]
        private string weapon;

        // 1. 定義列舉與選項
        // 2. 將列舉儲存於欄位內
        private enum Season
        {
            Spring, Summer, Fall, Winter
        }

        [SerializeField]
        private Season gameSeason;

        private void Awake()
        {
            gameSeason = Season.Fall;

            ChooseIf();
        }

        private void Update()
        {
            UpdateChooseIf();
            UpdateScoreIf();
            ChooseSwitch();
            SeasonSwitch();
        }

        #region if
        /// <summary>
        /// if
        /// </summary>
        private void ChooseIf()
        {
            // if (布林值) { 當布林值等於 true 執行 }
            if (true)
            {
                print("true 我是判斷式 if");
            }

            if (false)
            {
                print("false 我是判斷式 if");
            }
        }

        private void UpdateChooseIf()
        {
            // 如果 if 鑰匙 大於等於 5 就過關，否則 else 就不過關
            if (keyCount >= 5)
            {
                // 布林值 true 執行
                print("過關");
            }
            else
            {
                // 布林值 false 執行
                print("不過關");
            }
        }

        /// <summary>
        /// 分數：
        /// 大於等於 60 分：及格
        /// 低於 60 分：不及格
        /// 低於 40 分：被當
        /// </summary>
        private void UpdateScoreIf()
        {
            // if () {}
            // else if () {} - 必須放在 if 下方，else 上方 
            // else {}
            if (score >= 60)
            {
                print("及格");
            }
            else if (score >= 40)
            {
                print("不及格");
            }
            else
            {
                print("你被當了！");
            }
        }
        #endregion

        #region switch
        private void ChooseSwitch()
        {
            // swithc (任何資料類型) { 選取語句 }
            switch (weapon)
            {
                // 如果 武器 為 小刀 就執行 攻擊力 10 並且跳出
                case "小刀":
                    print("攻擊力 10");
                    break;

                case "手榴彈":
                    print("攻擊力 50");
                    break;

                // 當上面的 case 都不符合執行，可省略
                default:
                    print("這是不能用的武器");
                    break;
            }
        }

        private void SeasonSwitch()
        {
            switch (gameSeason)
            {
                case Season.Spring:
                    print("春天");
                    break;
                case Season.Summer:
                    print("夏天");
                    break;
                case Season.Fall:
                    print("秋天");
                    break;
                case Season.Winter:
                    print("冬天");
                    break;
            }
        }
        #endregion
    }
}

