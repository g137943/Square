using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.Events;



public class Counter : MonoBehaviour
{
    public int thisSquareCount = 1;

    public VoidEventSO ClickSoundSO;

    public void OnButtonClick()
    {
        if (thisSquareCount== CounterManager.instance.nowCount) 
        {
            Debug.Log("当前计数：" + CounterManager.instance.nowCount);
            CounterManager.instance.nowCount++;

            ClickSoundSO?.RaiseEvent();


            Destroy(this.gameObject);
        }
        else
        {
            Debug.Log("点错了啊啊啊啊啊啊");
        }
    }

    public void Test()
    {
        Debug.Log("Button");
    }
}
