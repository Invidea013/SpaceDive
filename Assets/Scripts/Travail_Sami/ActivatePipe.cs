using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePipe : MonoBehaviour
{

    public GameObject pipesUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            pipesUI.SetActive(true);
        }
    }
}
