using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quitgame : MonoBehaviour
{
    public void quitthegame ()
    {
        Application.Quit();
        Debug.Log("Quit game");
    }
}
