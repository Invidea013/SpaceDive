using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{

    public GameObject[] menuUI;
    public GameObject[] optionUI;
    public GameObject[] pauseUI;

    public void PlayButton()
    {
        SceneManager.LoadScene(1);
    }

    public void QuitButton()
    {
        Application.Quit();
    }

    public void RetryButton()
    {
        SceneManager.LoadScene(0);
    }

    public void OptionSelect()
    {
        menuUI[0].SetActive(false);
        menuUI[1].SetActive(false);
        menuUI[2].SetActive(false);
        optionUI[0].SetActive(true);
    }

    public void MenuReturn()
    {
        menuUI[0].SetActive(true);
        menuUI[1].SetActive(true);
        menuUI[2].SetActive(true);
        optionUI[0].SetActive(false);
    }

    public void PauseReturn()
    {
        pauseUI[0].SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void SoundReturn()
    {
        pauseUI[1].SetActive(false);
        pauseUI[0].SetActive(true);
    }

    public void ControlsReturn()
    {
        pauseUI[2].SetActive(false);
        pauseUI[0].SetActive(true);
    }

    public void SoundMenu()
    {
        pauseUI[0].SetActive(false);
        pauseUI[1].SetActive(true);
    }

    public void ControlsMenu()
    {
        pauseUI[0].SetActive(false);
        pauseUI[2].SetActive(true);
    }
}
