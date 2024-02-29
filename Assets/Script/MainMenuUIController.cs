using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenuUIController : MonoBehaviour
{
    public Button playButton;
    public Button creditButton;
    public Button exitButton;

    private void Start(){
        playButton.onClick.AddListener(PlayGame);
        creditButton.onClick.AddListener(CreditButton);
        exitButton.onClick.AddListener(ExitButton);
    }

    private void PlayGame(){
        SceneManager.LoadScene("MainGame");
    }

    private void CreditButton(){
        SceneManager.LoadScene("Credit");
    }

    public void ExitButton(){
        Application.Quit();
    }
}
