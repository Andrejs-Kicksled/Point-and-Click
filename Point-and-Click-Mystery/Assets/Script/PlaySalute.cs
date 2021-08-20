using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaySalute : MonoBehaviour
{

    [SerializeField] private Animator playSalute;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playSalute.SetBool("playSalute", true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            playSalute.SetBool("playSalute", false);
        }
    }

}
