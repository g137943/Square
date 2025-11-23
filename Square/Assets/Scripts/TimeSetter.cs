using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimeSetter : MonoBehaviour
{
    public IntDataSO data;

    public void SetTime(int value)
    {
        data.intValue = value;
        Debug.Log("数量已设置为：" + value);
    }
}
