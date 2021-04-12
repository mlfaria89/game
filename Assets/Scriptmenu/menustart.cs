using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Advertisements;

public class menustart : MonoBehaviour
{
    public void startgame()
    {
        if (PlayerPrefs.GetInt("lives", 2) > 0)
        {
            SceneManager.LoadScene("Game");
        }
    }

    public void goselectlevel()
    {
        SceneManager.LoadScene("Levelmenu");
    }

    public void backmenu()
    {
        SceneManager.LoadScene("Menu");
    }


}
