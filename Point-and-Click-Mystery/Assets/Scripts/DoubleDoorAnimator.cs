using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoubleDoorAnimator : MonoBehaviour
{
    [SerializeField] private Animator doubleDoorAnimatorControllerRight;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doubleDoorAnimatorControllerRight.SetBool("Player on Trigger", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            doubleDoorAnimatorControllerRight.SetBool("Player on Trigger", false);
        }
    }
}
