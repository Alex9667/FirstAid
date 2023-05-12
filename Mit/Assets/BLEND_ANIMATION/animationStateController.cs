using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animationStateController : MonoBehaviour
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
            animator.SetBool("isStanding", true);
        }
        if (other.gameObject.tag == "RightHand")
        {
            animator.SetBool("isStanding", false);
        }

    }

    //private void OnTriggerExit(Collider other)
    //{
    //    if (other.gameObject.tag == "LeftHand" && other.gameObject.tag == "RightHand")
    //    {
    //        animator.SetBool("isStanding", false);
    //    }
    //}
}
