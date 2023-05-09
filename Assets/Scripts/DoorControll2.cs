using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorControll2 : MonoBehaviour
{
    public Animator animator;
    public AudioSource audios;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {

            animator.SetBool("Open", true);
            audios.Play();
        }


    }
}
