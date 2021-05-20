using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject soundMenu;
    public GameObject controlsMenu;
    public GameObject player;

    void Start()
    {
        PlayerPrefs.SetInt("Pause", 1);
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape) && PlayerPrefs.GetInt("Pause") == 1)
        {
            Cursor.lockState = CursorLockMode.None;
            pauseMenu.SetActive(true);
            player.SetActive(false);
            PlayerPrefs.SetInt("Pause", 0);
        }

        if(PlayerPrefs.GetInt("Pause") == 1)
        {
            player.SetActive(true);
        }
    }
}
