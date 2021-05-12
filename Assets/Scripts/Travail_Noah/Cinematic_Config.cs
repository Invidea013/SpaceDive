using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cinematic_Config : MonoBehaviour
{
    public GameObject[] Cinematics;
    public AudioSource[] cinematicSources;
    public AudioClip[] cinematicClips;

    private float Timer;

    void Start()
    {
        cinematicSources[0].Play();
    }

    void Update()
    {
        Timer += Time.deltaTime;

        if (Timer >= 5f)
        {
            Cinematics[0].SetActive(true);
            cinematicSources[1].Play();
        }

        if (Timer >= 10f)
        {
            Cinematics[1].SetActive(true);

            cinematicSources[1].Stop();
            cinematicSources[2].PlayOneShot(cinematicClips[2]);
        }

        if(Timer >= 11f)
        {
            cinematicSources[3].PlayOneShot(cinematicClips[3]);
        }

        if(Timer >= 11.5f)
        {
            cinematicSources[4].PlayOneShot(cinematicClips[4]);
            cinematicSources[5].PlayOneShot(cinematicClips[5]);
        }

        if(Timer >= 12f)
        {
            cinematicSources[6].PlayOneShot(cinematicClips[6]);
        }

        if (Timer >= 13f)
        {
            SceneManager.LoadScene(2);
        }
    }
}
