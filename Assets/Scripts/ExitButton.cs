using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ExitButton : MonoBehaviour
{
    public Button exitButton;

    public void onClick()
    {
        Level.levelComplexity = -1;
        SceneManager.LoadScene("MainMenu");
    }
}
