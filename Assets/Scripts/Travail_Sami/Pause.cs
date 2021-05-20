using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject soundMenu;
    public GameObject controlsMenu;

    public PlayerManager playerManager;
    public CameraControls cameraControls;

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
            playerManager.enabled = false;
            cameraControls.enabled = false;
            PlayerPrefs.SetInt("Pause", 0);
        }

        if(PlayerPrefs.GetInt("Pause") == 1)
        {
            playerManager.enabled = true;
            cameraControls.enabled = true;
        }
    }
}
