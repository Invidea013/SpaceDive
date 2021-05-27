using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MJCodeManager : MonoBehaviour
{
    public GameObject mjCodeCanvas;
    public GameObject freezPanel;

    public AudioSource soundSource;
    public AudioClip endClip;
    public AudioClip ledOn; 
    public AudioClip ledOff;

    public bool taskDone = false;

    public GameObject led1;
    public GameObject led2;
    public GameObject led3;

    void Update()
    {
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
    }

    IEnumerator TaskIsDone()
    {
        yield return new WaitForSeconds(2);
        mjCodeCanvas.SetActive(false);
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
