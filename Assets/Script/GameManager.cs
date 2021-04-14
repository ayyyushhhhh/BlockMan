using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private GameObject panel;
    [SerializeField] private Text scoreText;
    [SerializeField] private float score=0;
    public void Pause()
    {  
        Time.timeScale=0;
        panel.SetActive(true);
    }
    
    public void Resume()
    {
        Time.timeScale=1;
        panel.SetActive(false);
    }
    public void Menu()
    {   
        Time.timeScale=1;
        SceneManager.LoadScene(sceneName: "menu");
    }

    public void StartGame()
    {
        SceneManager.LoadScene(sceneName: "Level 1");
    }
    
    public void Retry()
    {
        SceneManager.LoadScene(sceneName: "Level 1");
        Time.timeScale = 1;
        
    }

    private void Update()
    {   
        
        if (scoreText != null&& Time.timeScale!=0)
        {   
            score += Time.deltaTime;
            scoreText.text = ((int)score).ToString();
        }
        
    }
}
