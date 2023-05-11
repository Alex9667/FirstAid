using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;
using UnityEngine.XR.Interaction.Toolkit;

public class HeartMassage : MonoBehaviour
{
    public XRBaseController leftController;
    public XRBaseController rightController;


    public TMP_Text Text;
    bool LeftHand;
    bool RightHand;

    public AudioSource Sound;


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
            Sound.Play();

            pushes++;

            TriggerHaptic(leftController, rightController);

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

    public void TriggerHaptic(XRBaseController controller1, XRBaseController controller2)
    {
        controller1.SendHapticImpulse(0.3f, 0.1f);
        controller2.SendHapticImpulse(0.3f, 0.1f);

    }
}
