using UnityEngine;

namespace KID
{
    /// <summary>
    /// 彈珠格子管理器：判斷被彈珠碰到後添加彈珠上限
    /// </summary>
    public class MarbleBoxManager : MonoBehaviour
    {
        private ControlSystem controlSystem;
        private string nameMarble = "彈珠";

        private void Awake()
        {
            controlSystem = GameObject.Find("小藍").GetComponent<ControlSystem>();
        }

        private void OnTriggerEnter(Collider other)
        {
            // print($"<color=#2266ff>碰到彈珠格子的物件：{ other.name }</color>");

            if (other.name.Contains(nameMarble))
            {
                controlSystem.addMarbleThisTurn++;
                Destroy(gameObject);
            }
        }
    }
}
