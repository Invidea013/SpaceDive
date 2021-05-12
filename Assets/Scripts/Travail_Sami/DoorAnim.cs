using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnim : MonoBehaviour
{

    public Animator doorAnim;

    public AudioSource doorSource;
    public AudioClip[] doorClips;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            doorAnim.SetTrigger("isOpening");
            doorSource.PlayOneShot(doorClips[0]);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnim.SetTrigger("isClosing");
            doorSource.PlayOneShot(doorClips[1]);
        }
    }
}
