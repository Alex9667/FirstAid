using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class MenuScript : MonoBehaviour
{
    public TMP_InputField PlayerInput;
    public TMP_Text txt;

    private string name;
    public void LoadScene()
    {
        try
        {
            name = PlayerInput.text;
            txt.text = name;
            //Api call
        }
        catch (Exception e)
        {
            Debug.LogException(e);
        }
        finally
        {
            SceneManager.LoadScene("SampleScene");
        }




    }
}
