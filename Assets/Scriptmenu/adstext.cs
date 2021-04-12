using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class adstext : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        if (PlayerPrefs.GetInt("lives", 2) < 1)
        {
            GameObject textobject = this.gameObject;
            Text text = textobject.GetComponent<Text>();
            text.text = text.text + "\n(watch ad to play)";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
