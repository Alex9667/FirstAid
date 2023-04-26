using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;
using UnityEngine.Networking;

public class MenuScript : MonoBehaviour
{
    public TMP_InputField PlayerInput;
    public TMP_Text txt;

    private string name;
    public IEnumerator LoadScene()
    {
        if (PlayerInput.text == null || PlayerInput.text == "")
        {
            name = "Ikke angivet";
        }
        else
        {
            name = PlayerInput.text;
            txt.text = name;
        }
        //Api call
        WWWForm form = new WWWForm();
        form.AddField("Navn", "\"" + name + "\"");
        UnityWebRequest request = UnityWebRequest.Post("https://api.nexusvr.tech/example", form);
        yield return request.SendWebRequest();

        if (request.result != UnityWebRequest.Result.Success)
        {
            Debug.Log(request.error);
        }

            //Change scene after the api call
            SceneManager.LoadScene("SampleScene");
    }
}

