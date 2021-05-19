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


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            Cursor.lockState = CursorLockMode.None;
            pauseMenu.SetActive(true);
            playerManager.enabled = false;
            cameraControls.enabled = false;
            PlayerPrefs.SetInt("Pause", 0);
        }
    }
}
