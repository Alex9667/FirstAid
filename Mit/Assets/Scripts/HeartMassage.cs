using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

public class HeartMassage : MonoBehaviour
{
    public TMP_Text Text;
    bool LeftHand;
    bool RightHand;

    private float pushes;
    // Start is called before the first frame update
    void Start()
    {
        LeftHand= false;
        RightHand= false;
        pushes = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Text.text = pushes.ToString();
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "LeftHand")
        {
            LeftHand= true;
        }
        else if(other.gameObject.tag == "RightHand")
        {
            RightHand= true;
        }
        if(RightHand == true && LeftHand == true)
        {
            pushes++;

            RightHand= false;
            LeftHand= false;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "LeftHand")
        {
            LeftHand = false;
        }
        else if (other.gameObject.tag == "RightHand")
        {
            RightHand = false;
        }
    }
}
