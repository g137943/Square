using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CounterManager : MonoBehaviour
{
    int squareCount;

    public int nowCount = 1;



    bool isOver=false;
    public static CounterManager instance { get; private set; }
    private void Awake()
    {
        instance = this;          //为赋值
        squareCount = GameSettings.instance.squareCount;
        
    }

    private void Update()
    {
        if (isOver == false)
        {
            if (nowCount > squareCount)
            {
                Debug.Log("游戏胜利");
                isOver = true;

                //TODO:进入游戏胜利界面
                //加载胜利场景
                UnityEngine.SceneManagement.SceneManager.LoadScene("GameWin");

            }
        }
    }







}
