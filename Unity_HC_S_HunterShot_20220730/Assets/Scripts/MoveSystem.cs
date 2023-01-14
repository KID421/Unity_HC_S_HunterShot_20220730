﻿using UnityEngine;
using System.Collections;

namespace KID
{
    /// <summary>
    /// 在敵人回合需要移動的物件
    /// </summary>
    public class MoveSystem : MonoBehaviour
    {
        [SerializeField, Header("要移動的單位"), Range(0, 10)]
        private float moveDistance = 2;

        private TurnSystem turnSystem;
        private WaitForSeconds intervalMove = new WaitForSeconds(0.03f);

        private void Awake()
        {
            turnSystem = FindObjectOfType<TurnSystem>();

            // 回合系統.敵人回合事件.添加監聽器(移動) - 切換到敵人回合時此物件會移動
            turnSystem.onEnemyTurn.AddListener(Move);
        }

        /// <summary>
        /// 移動
        /// </summary>
        private void Move()
        {
            StartCoroutine(MoveEffect());
        }

        /// <summary>
        /// 移動效果
        /// </summary>
        private IEnumerator MoveEffect()
        {
            float moveCount = 10;
            float moveOnce = moveDistance / moveCount;     // 移動十次

            for (int i = 0; i < moveCount; i++)
            {
                transform.position -= transform.forward * moveOnce;
                yield return intervalMove;
            }
        }
    }
}