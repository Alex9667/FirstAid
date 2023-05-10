using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class HandZone : MonoBehaviour
{
    public GameObject rightHandStandIn;
    public GameObject leftHandStandIn;

    bool RightHand;
    bool LeftHand;

    // Start is called before the first frame update
    void Start()
    {
        RightHand = false;
        LeftHand = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LeftHand")
        {
            LeftHand = true;
        }
        else if (other.gameObject.tag == "RightHand")
        {
            RightHand = true;
        }
        if (RightHand == true && LeftHand == true)
        {
            rightHandStandIn.SetActive(false);
            leftHandStandIn.SetActive(false);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "LeftHand")
        {
            LeftHand = false;
            leftHandStandIn.SetActive(true);
            rightHandStandIn.SetActive(true);
        }
        else if (other.gameObject.tag == "RightHand")
        {
            RightHand = false;
            rightHandStandIn.SetActive(true);
            leftHandStandIn.SetActive(true);
        }
    }
}
