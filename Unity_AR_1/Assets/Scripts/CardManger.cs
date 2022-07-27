using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Quentin.AR.Vuforia
{
    /// <summary>
    /// 圖片辨識管理器
    /// </summary>
    public class CardManger : MonoBehaviour
    {
        [SerializeField, Header("KID圖片")]
        private DefaultObserverEventHandler observerKID;

        private void Awake()
        {
            observerKID.OnTargetFound.AddListener(cardFound);
            observerKID.OnTargetFound.AddListener(cardLost);
        }
        

        private void cardFound()
        {
            print("<color=yellow>找到卡片</color>");
        }

        private void cardLost()
        {
            print("<color=red>卡片辨識失敗</color>");
        }


    }


}
