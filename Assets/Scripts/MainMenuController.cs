using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MainMenuController : MonoBehaviour
{
    public void PlayGame(){
        SceneManager.LoadScene("Game",LoadSceneMode.Single);
    }

    public void GameOver(){
        SceneManager.LoadScene("GameOver");
    }

    public void HowToPlay(){
        SceneManager.LoadScene("HowToPlay");
    }

    public void BackToMainMenu(){
        SceneManager.LoadScene("Main Menu");
    }

    public void Exit(){
        Application.Quit();
    }
}