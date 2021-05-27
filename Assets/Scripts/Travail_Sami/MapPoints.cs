using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MapPoints : MonoBehaviour
{

    public GameObject[] mapPoints;
    public MJCodeManager codeManager;
    public MJPipesManager pipeManager;

    void Update()
    {
        if(codeManager.taskDone == true)
        {
            mapPoints[7].SetActive(false);
        }

        if(pipeManager.taskDone == true)
        {
            mapPoints[8].SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Cockpit"))
        {
            mapPoints[0].SetActive(true);
        }

        if (other.CompareTag("Office_1"))
        {
            mapPoints[1].SetActive(true);
        }

        if (other.CompareTag("Office_2"))
        {
            mapPoints[2].SetActive(true);
        }

        if (other.CompareTag("Storage_1"))
        {
            mapPoints[3].SetActive(true);
        }

        if (other.CompareTag("Storage_2"))
        {
            mapPoints[4].SetActive(true);
        }

        if (other.CompareTag("Kitchen"))
        {
            mapPoints[5].SetActive(true);
        }

        if (other.CompareTag("Reactor"))
        {
            mapPoints[6].SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Cockpit"))
        {
            mapPoints[0].SetActive(false);
        }

        if (other.CompareTag("Office_1"))
        {
            mapPoints[1].SetActive(false);
        }

        if (other.CompareTag("Office_2"))
        {
            mapPoints[2].SetActive(false);
        }

        if (other.CompareTag("Storage_1"))
        {
            mapPoints[3].SetActive(false);
        }

        if (other.CompareTag("Storage_2"))
        {
            mapPoints[4].SetActive(false);
        }

        if (other.CompareTag("Kitchen"))
        {
            mapPoints[5].SetActive(false);
        }

        if (other.CompareTag("Reactor"))
        {
            mapPoints[6].SetActive(false);
        }
    }

}
