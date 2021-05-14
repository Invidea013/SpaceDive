using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Victory : MonoBehaviour
{
    public PlayerManager playerManager;

    public GameObject playerUI;
    public GameObject[] victoryUI;
    public GameObject fadeOut;
    public GameObject fadeIn;

    private float timer;
    private bool victory = false;
    
    // Start is called before the first frame update
    void Start()
    {
        playerManager.GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if(victory == true)
        {
            timer += Time.deltaTime;

            fadeOut.SetActive(true);

            playerManager.AudioList[0].Stop();
            playerManager.AudioList[1].Stop();
            playerManager.AudioList[2].Stop();

            if (!playerManager.AudioList[11].isPlaying)
            {
                playerManager.AudioList[11].PlayOneShot(playerManager.ClipList[7]);
            }

            if(timer >= 1f)
            {
                victoryUI[0].SetActive(true);
                playerUI.SetActive(false);

                victoryUI[1].SetActive(true);
                victoryUI[2].SetActive(true);
                victoryUI[3].SetActive(true);

                Cursor.lockState = CursorLockMode.None;
            }

            if(timer >= 1.4f)
            {
                playerManager.AudioList[11].Stop();
            }

            if (timer >= 2f)
            {
                fadeIn.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Victory"))
        {
            playerManager.enabled = false;
            victory = true;
        }
    }
}
