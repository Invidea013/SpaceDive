using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MJCodeManager : MonoBehaviour
{
    public GameObject mjCodeCanvas;
    public GameObject freezPanel;
    public GameObject codeTrigger;

    public PlayerManager playerManager;
    public CameraControls cameraControls;
    public Pause pause;

    public AudioSource soundSource;
    public AudioClip endClip;
    public AudioClip ledOn; 
    public AudioClip ledOff;

    public bool taskDone = false;

    public GameObject led1;
    public GameObject led2;
    public GameObject led3;

    void Start()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    void Update()
    {
        playerManager.AudioList[0].Stop();
        playerManager.AudioList[1].Stop();
        playerManager.AudioList[2].Stop();

        playerManager.enabled = false;
        cameraControls.enabled = false;
        pause.enabled = false;

        Cursor.lockState = CursorLockMode.None;

        if (led1.GetComponent<MJCodeLED>().isTrue == true && led2.GetComponent<MJCodeLED>().isTrue == true && led3.GetComponent<MJCodeLED>().isTrue == true)
        {
            //condition de victoire 
            taskDone = true;
            freezPanel.SetActive(true);
            StartCoroutine(TaskIsDone());
        }
    }

    public void QuitTask()
    {
        mjCodeCanvas.SetActive(false);

        playerManager.enabled = true;
        cameraControls.enabled = true;
        pause.enabled = true;

        Cursor.lockState = CursorLockMode.Locked;
    }

    IEnumerator TaskIsDone()
    {
        yield return new WaitForSeconds(2);

        mjCodeCanvas.SetActive(false);

        playerManager.enabled = true;
        cameraControls.enabled = true;
        pause.enabled = true;

        Destroy(codeTrigger);

        Cursor.lockState = CursorLockMode.Locked;
    }

    public void PlayLEDOn()
    {
        soundSource.PlayOneShot(ledOn);
        Debug.Log("bruit on");
    }

    public void PlayLEDOff()
    {
        soundSource.PlayOneShot(ledOff);
        Debug.Log("bruit on");
    }

    public void PlayEND()
    {
        soundSource.PlayOneShot(endClip);
        Debug.Log("bravo champion");
    }
}
