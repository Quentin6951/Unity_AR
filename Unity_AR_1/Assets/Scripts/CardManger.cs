using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Quentin.AR.Vuforia
{
    /// <summary>
    /// �Ϥ����Ѻ޲z��
    /// </summary>
    public class CardManger : MonoBehaviour
    {
        [SerializeField, Header("KID�Ϥ�")]
        private DefaultObserverEventHandler observerKID;

        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(cardFound);
            observerKID.OnTargetFound.AddListener(cardLost);
        }
        

        private void cardFound()
        {
            print("<color=yellow>���d��</color>");
        }

        private void cardLost()
        {
            print("<color=red>�d�����ѥ���</color>");
        }


    }


}
