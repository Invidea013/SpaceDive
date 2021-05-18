using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{

    public GameObject pauseMenu;
    public GameObject soundMenu;
    public GameObject controlsMenu;

    public PlayerManager playerManager;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Escape))
        {
            pauseMenu.SetActive(true);
            playerManager.enabled = false;
        }

        if(PlayerPrefs.GetInt("Pause") == 1)
        {
            pauseMenu.SetActive(false);
            playerManager.enabled = true;
        }

    }
}
