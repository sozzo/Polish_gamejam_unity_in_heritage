using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public static class Level 
{
    private enum complexity
    {
        ez = 0,
        normal = 1,
        hard = 2
    }
    public static int levelComplexity;

    public static void CreateLevel()
    {
        SceneManager.LoadScene("gameplay");
    }
}
