using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace Quentin.AR.Vuforia
{
    /// <summary>
    /// 圖片辨識管理器
    /// </summary>
    public class CardManger : MonoBehaviour
    {
        [SerializeField, Header("KID圖片")]
        private DefaultObserverEventHandler observerKID;
        [SerializeField, Header("小騎士")]
        private Animator aniknight;
        [SerializeField, Header("攻擊")]
        private Button btnAttack;
        [SerializeField, Header("虛擬按鈕跳躍")]
        private VirtualButtonBehaviour vbbJump;

        private string parVictory = "觸發勝利";
        private AudioSource audBGM;
        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(cardFound);
            observerKID.OnTargetLost.AddListener(cardLost);
            
            btnAttack.onClick.AddListener(Attack);

            vbbJump.RegisterOnButtonPressed(OnJumpPressed);

            audBGM = GameObject.Find("BGM").GetComponent<AudioSource>();
        }

        private void OnJumpPressed(VirtualButtonBehaviour obj)
        {
            print("<color=#3366dd>跳躍!!!</color>");
        }

        /// <summary>
        ///  圖片辨識成功
        /// </summary>

        private void cardFound()
        {
            print("<color=yellow>找到卡片</color>");
            aniknight.SetTrigger(parVictory);
            audBGM.Play();
        }

        /// <summary>
        /// 圖片辨識失敗
        /// </summary>

        private void cardLost()
        {
            print("<color=red>卡片辨識失敗</color>");
            audBGM.Stop();
        }

        private void Attack()
        {
            print("<color=#9955aa>攻擊!!!</color>");
        }


    }


}
