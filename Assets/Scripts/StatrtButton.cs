using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class StatrtButton : MonoBehaviour
{
    public Button startButton;

    //ToggleGroup toggleGroupInstance;

    //void Start()
    //{
    //    toggleGroupInstance = GetComponent<ToggleGroup>();
    //}

    //public void SetComplexity()
    //{
    //    toggleGroupInstance = GetComponent<ToggleGroup>();
    //    Debug.Log(toggleGroupInstance.name);
    //    var toggles = toggleGroupInstance.GetComponentsInChildren<Toggle>();
    //    for(int i = 0; i< toggles.Length; i++)
    //    {
    //        if (toggles[i].isOn)
    //        {
    //            Level.levelComplexity = i + 1;
    //            Debug.Log($"comlexity = {Level.levelComplexity}");
    //            return;
    //        }
    //    }
    //}
    public void onClick()
    {
        
        //SetComplexity();
        Level.CreateLevel();
    }
}
