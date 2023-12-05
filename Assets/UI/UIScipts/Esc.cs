using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System;
using UnityEditor;

public class Esc : MonoBehaviour
{
    public GameObject PausePanel;
    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Pause();
        }
        if (Input.GetKeyDown(KeyCode.Escape)&&PausePanel.active==true)
        {
            Application.Quit();
        }
        if (Input.GetKeyDown(KeyCode.Space) && PausePanel.active == true)
        {
            PausePanel.SetActive(false);
            Time.timeScale = 1;
        }


    }
    public void Pause()
    {
        Time.timeScale = 0;
        PausePanel.SetActive(true);
        
    }

    public void Countinue()
    {
        PausePanel.SetActive(false);
        Time.timeScale = 1;
    }
}
