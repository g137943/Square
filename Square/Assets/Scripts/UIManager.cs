using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject timeStopPennel;



    // 每次调用切换 active 状态：当前为 false 则设为 true，当前为 true 则设为 false
    public void ToggleTimeStopPennel()
    {
        if (timeStopPennel == null)
        {
            Debug.LogWarning("UIManager: timeStopPennel 未赋值。请在 Inspector 中分配对应的 GameObject。");
            return;
        }

        timeStopPennel.SetActive(!timeStopPennel.activeSelf);

        //切换暂停状态
        if(TimeManager.instance.isStopped)
        {
            TimeManager.instance.isStopped = false;
        }
        else
        {
            TimeManager.instance.isStopped = true;
        }
    }
}
