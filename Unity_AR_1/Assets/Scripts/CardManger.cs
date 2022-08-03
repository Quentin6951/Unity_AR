using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Vuforia;

namespace Quentin.AR.Vuforia
{
    /// <summary>
    /// �Ϥ����Ѻ޲z��
    /// </summary>
    public class CardManger : MonoBehaviour
    {
        [SerializeField, Header("KID�Ϥ�")]
        private DefaultObserverEventHandler observerKID;
        [SerializeField, Header("�p�M�h")]
        private Animator aniknight;
        [SerializeField, Header("����")]
        private Button btnAttack;
        [SerializeField, Header("�������s���D")]
        private VirtualButtonBehaviour vbbJump;

        private string parVictory = "Ĳ�o�ӧQ";
        private string parJump = "Ĳ�o���D";
        private string parAttack = "Ĳ�o����";

        private AudioSource audBGM;
        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(cardFound);
            observerKID.OnTargetLost.AddListener(cardLost);
            
            btnAttack.onClick.AddListener(Attack);

            vbbJump.RegisterOnButtonPressed(OnJumpPressed);

            audBGM = GameObject.Find("BGM").GetComponent<AudioSource>();
        }
        //Ĳ�o���D
        private void OnJumpPressed(VirtualButtonBehaviour obj)
        {
            print("<color=#3366dd>���D!!!</color>");
            aniknight.SetTrigger(parJump);
        }

        /// <summary>
        ///  �Ϥ����Ѧ��\
        /// </summary>

        private void cardFound()
        {
            print("<color=yellow>���d��</color>");
            aniknight.SetTrigger(parVictory);
            audBGM.Play();
        }

        /// <summary>
        /// �Ϥ����ѥ���
        /// </summary>

        private void cardLost()
        {
            print("<color=red>�d�����ѥ���</color>");
            audBGM.Stop();
        }
        //Ĳ�o����
        private void Attack()
        {
            print("<color=#9955aa>����!!!</color>");
            aniknight.SetTrigger(parAttack);
        }


    }


}
