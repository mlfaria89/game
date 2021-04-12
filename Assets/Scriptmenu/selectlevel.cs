using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectlevel : MonoBehaviour
{
    public GameObject mytext;
    public static int level = 1;

    public void selecteasy()
    {
        // change vector to easy

        // change text
        mytext = GameObject.Find("Canvas/leveltext");
        Text txt = mytext.GetComponent<Text>();
        txt.text = "EASY";
        txt.color = Color.green;
        level = 1;

    }

    public void selecthard()
    {
        // change vector to hard
        // change text
        mytext = GameObject.Find("Canvas/leveltext");
        Text txt = mytext.GetComponent<Text>();
        txt.text = "HARD";
        txt.color = Color.red;
        level = 3;

    }

    public void selectnormal()
    {
        //change vector to normal
        // change text
        mytext = GameObject.Find("Canvas/leveltext");
        Text txt = mytext.GetComponent<Text>();
        txt.text = "NORMAL";
        txt.color = Color.blue;
        level = 2;
    }
}
