using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StatrtButton : MonoBehaviour
{
    public Button startButton;
    public static void onClick()
    {
        //SceneManager.LoadScene("gameplay");
        Level.levelComplexity = 0;
        Level.CreateLevel();
    }
}
