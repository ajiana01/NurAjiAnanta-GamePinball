using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CreditUIController : MonoBehaviour
{
    public Button mainMenu;

    private void Start(){
        mainMenu.onClick.AddListener(Back);
    }

    private void Back(){
        SceneManager.LoadScene("MainMenu");
    }
}
