using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorAnimator : MonoBehaviour
{
    [SerializeField] public Animator doorAnimatorControllerRight;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            doorAnimatorControllerRight.SetBool("Player_Near", true);
        }       
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doorAnimatorControllerRight.SetBool("Player_Near", false);
        }
    }
}

