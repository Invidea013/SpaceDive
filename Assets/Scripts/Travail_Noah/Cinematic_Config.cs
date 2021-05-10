using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cinematic_Config : MonoBehaviour
{
    public GameObject[] Cinematics;
    private float Timer;
    // Update is called once per frame
    void Update()
    {
        Timer += Time.deltaTime;
        if (Timer >= 3f)
        {
            Cinematics[0].SetActive(true);
            
        }
        if (Timer >= 6f)
        {
            Cinematics[1].SetActive(true);
        }
        if (Timer >= 9f)
        {
            Cinematics[2].SetActive(true);
        }
        if (Timer >= 15f)
        {
            SceneManager.LoadScene(1);
        }
    }
}
