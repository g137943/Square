using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuLevelSelecter : MonoBehaviour
{
    
    public string levelToLoad;



    public void SelectLevel(string levelToLoad)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(levelToLoad);
    }
}
