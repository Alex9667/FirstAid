using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestAnimationStateController : MonoBehaviour
{
    public Animator animator;
    bool LeftHand;
    bool RightHand;

    public void OnTriggerEnter(Collider other)
    {
        // if right or left controller enters model's collision
        if (other.gameObject.tag == "LeftHand")
        {
            // then change animation state
            animator.SetBool("isMassaging", true);
        }
        if (other.gameObject.tag == "RightHand")
        {
            animator.SetBool("isMassaging", false);
        }

    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.tag == "LeftHand" && other.gameObject.tag == "RightHand")
    //    {
    //        animator.SetBool("isMassaging", false);
    //    }
    //}


    // EKSTRA NOTER:
    // s�tte animation state til at blive false n�r h�nder er ude for zone for t�ller
}
