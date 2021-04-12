using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class loadingtext : MonoBehaviour
{

    public void appearloading()
    {
        GameObject button = this.gameObject;

        GameObject textbutton = button.transform.GetChild(0).gameObject;
        Text buttontext = textbutton.GetComponent<Text>();

        buttontext.text = "Loading...";

    }

}