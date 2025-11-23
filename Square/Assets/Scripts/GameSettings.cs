using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameSettings : MonoBehaviour
{
    [Header("设置参数")]
    public int squareCount = 8;
    public float playTime;

    [Header("SO")]
    public IntDataSO data;
    public static GameSettings instance { get; private set; }
    private void Awake()
    {
        instance = this;          //为赋值
        playTime = (float)data.intValue; //初始赋值
    }





}
