using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateCode : MonoBehaviour
{
    public GameObject codeUI;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            codeUI.SetActive(true);
            Cursor.lockState = CursorLockMode.None;
        }
    }
}
