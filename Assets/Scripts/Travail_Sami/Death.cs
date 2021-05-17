using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Death : MonoBehaviour
{

    public PlayerManager playerManager;
    public CameraControls cameraControls;

    public GameObject playerUI;
    public GameObject defeatUI;
    public GameObject fadeOut;
    public GameObject fadeIn;

    public Animator deathAnim;

    private float timer;

    // Start is called before the first frame update
    void Start()
    {
        playerManager.GetComponent<PlayerManager>();
        cameraControls.GetComponent<CameraControls>();
    }

    // Update is called once per frame
    void Update()
    {
        if(playerManager.OxBarNumber == 0)
        {
            playerManager.enabled = false;
            cameraControls.enabled = false;
            timer += Time.deltaTime;
            deathAnim.SetTrigger("isDying");

            if(!playerManager.AudioList[10].isPlaying)
            {
                playerManager.AudioList[10].PlayOneShot(playerManager.ClipList[6]);
            }

            if(timer >= 4f)
            {
                fadeOut.SetActive(true);
                playerManager.AudioList[10].Stop();
                deathAnim.SetTrigger("isDead");
            }

            if(timer >= 6f)
            {
                playerUI.SetActive(false);
                defeatUI.SetActive(true);

                Cursor.lockState = CursorLockMode.None;
            }

            if(timer >= 7f)
            {
                fadeIn.SetActive(false);
            }
        }
    }
}
