using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.EventSystems;
using UnityEngine.UI;
using Microsoft.MixedReality.Toolkit.Input;
public class JasonTracking : MonoBehaviour, IMixedRealityFocusHandler// IMixedRealityFocusHandler 是實現 eyetracking 的接口
{
    protected static PointerEventData leftClickEventData => new PointerEventData(EventSystem.current);
    public IPointerClickHandler clickTarget;//自身ui 組件
     

    
    public void OnFocusEnter(FocusEventData eventData)//注視到物件 執行一次 
    {
        // Debug.Log("OnFocusEnter");
        IPointerDownHandler pointerDown = clickTarget as IPointerDownHandler;//轉型成IPointerDownHandler
        pointerDown?.OnPointerDown(leftClickEventData); //按下時顯示閃
    }

    public void OnFocusExit(FocusEventData eventData)//移開物件
    {
        //Debug.Log("OnFocusExit");
        IPointerUpHandler pointerUp = clickTarget as IPointerUpHandler;
        pointerUp?.OnPointerUp(leftClickEventData);//放開時顯示變回本來顏色
        clickTarget?.OnPointerClick(leftClickEventData);//執行onclick方法
    }
    private void Awake()
    {
        clickTarget = GetComponent<IPointerClickHandler>();
         
    }


}
