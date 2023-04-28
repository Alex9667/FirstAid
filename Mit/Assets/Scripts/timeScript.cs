using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class timeScript : MonoBehaviour
{
    public GameObject image;
    public GameObject text;
    public AudioSource notificationSound;

    private DateTime endTime;

    // Start is called before the first frame update
    void Start()
    {
        text.SetActive(false);
        image.SetActive(false);
        endTime = DateTime.Now.AddMinutes(30);
    }

    // Update is called once per frame
    void Update()
    {
       // text.gameObject.SetActive(true);
       if(DateTime.Now >= endTime)
        {
            notificationSound.Play();
            image.SetActive(true);
            text.SetActive(true);
            StartCoroutine(wait());
        }
    }

    private IEnumerator wait()
    {
        endTime = DateTime.Now.AddMinutes(30);
        yield return new WaitForSeconds(10);
        text.SetActive(false);
        image.SetActive(false);
    }
}
