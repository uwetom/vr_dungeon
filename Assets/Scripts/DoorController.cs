using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public Animator animator;
    public AudioSource audios;
    private bool doorOpen = false;

    public void OpenDoor()
    {
        if (!doorOpen)
        {
            doorOpen = true;
            animator.SetBool("Open", true);
            audios.Play();
        }
    }
}
