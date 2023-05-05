using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeartMassagePose : MonoBehaviour
{
    public HandData rightHandPose;
    public HandData leftHandPose;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RightHand")
        {
            //righthand.activate
        }
        if (other.gameObject.tag == "LeftHand")
        {
            //lefthand.activate
        }

        // Make hand pose

        // Create new hand model and set pose
    }
    private void OnTriggerExit(Collider other)
    {

        // When just one hand exits zone, the hand pose stops and reset to default


        if (other.gameObject.tag == "RightHand")
        {
            //righthand.deactivate
        }
        if (other.gameObject.tag == "LeftHand")
        {
            // lefthand.deactivate
        }
    }
}
