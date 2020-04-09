using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    [SerializeField] GameObject mainMenu;
    [SerializeField] GameObject creditsMenu;



    public void QuitGame()
    {

//runs if either one depending on how you open it
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#else
       
        Application.Quit();
#endif



    }


    public void StartGame()
    {
        SceneManager.LoadScene("Street");



    }


    public void ShowCredits()
    {

        mainMenu.SetActive(false);
        creditsMenu.SetActive(true);


    }


    public void ShowMainMenu()
    {

        mainMenu.SetActive(true);
        creditsMenu.SetActive(false);



    }





}
