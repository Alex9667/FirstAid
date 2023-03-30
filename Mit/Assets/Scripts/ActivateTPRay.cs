using UnityEngine;
using UnityEngine.InputSystem;

public class ActivateTPRay : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject LeftTPRay;

    public InputActionProperty LeftActivate;

    // Update is called once per frame
    void Update()
    {
        LeftTPRay.SetActive(LeftActivate.action.ReadValue<float>() > 0.1f);
    }
}
