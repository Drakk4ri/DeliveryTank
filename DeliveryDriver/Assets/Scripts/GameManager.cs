using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System;
using UnityEngine.Events;


public class GameManager : MonoBehaviour
{
    [SerializeField] MainMenuScreen mainMenuScreen;
    [SerializeField] GameScreen gameScreen;
    [SerializeField] EndScreen endScreen;
    [SerializeField] PointSystem pointSystem;


    void Start()
    {

        mainMenuScreen.gameObject.SetActive(true);
        gameScreen.gameObject.SetActive(false);
        endScreen.gameObject.SetActive(false);
       
    }

    
    void Update()
    {
        
    }

    public void OnReplayLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    public void StartTheGame()
    {
        mainMenuScreen.gameObject.SetActive(false);
        gameScreen.gameObject.SetActive(true);
        endScreen.gameObject.SetActive(false);
    }

    public void EnterEndGameView()
    {
        mainMenuScreen.gameObject.SetActive(false);
        gameScreen.gameObject.SetActive(false);
        endScreen.gameObject.SetActive(true);
    }

}
