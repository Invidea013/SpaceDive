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
    private float timeSec;

    void Update()
    {
        Timer += Time.deltaTime;
        if(Timer >= 1f)
        {
            timeSec++;
            Timer = 0f;
        }

        if(Input.GetKeyDown(KeyCode.Escape))
        {
            SceneManager.LoadScene(2);
        }

        Cinematic();
    }

    public void Cinematic()
    {
        if (timeSec == 5)
        {
            Cinematics[0].SetActive(true);
            if(!cinematicSources[1].isPlaying)
            {
                cinematicSources[1].Play();
            }
        }

        if (timeSec == 10)
        {
            Cinematics[1].SetActive(true);

            cinematicSources[1].Stop();
            if(!cinematicSources[2].isPlaying)
            {
                cinematicSources[2].PlayOneShot(cinematicClips[2]);
            }
        }

        if (timeSec == 11)
        {
            if(!cinematicSources[3].isPlaying && !cinematicSources[4].isPlaying && !cinematicSources[5].isPlaying && !cinematicSources[6].isPlaying)
            {
                cinematicSources[3].PlayOneShot(cinematicClips[3]);
                cinematicSources[4].PlayOneShot(cinematicClips[4]);
                cinematicSources[5].PlayOneShot(cinematicClips[5]);
                cinematicSources[6].PlayOneShot(cinematicClips[6]);
            }
        }

        if (timeSec == 15f)
        {
            SceneManager.LoadScene(2);
        }
    }

}
