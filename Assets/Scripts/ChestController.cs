using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    public Animator animator;
    public AudioSource audios;
    public ParticleSystem particles;


    private bool ChestOpen = false;

  
    public void touchChest()
    {
        if (ChestOpen == false)
        {
            ChestOpen = true;
            Debug.Log("chest touched");

            animator.SetTrigger("Open");
            audios.Play();

            particles.Play();
        }


    }
}
