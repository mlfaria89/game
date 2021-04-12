using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hitfoodef : MonoBehaviour
{

    public GameObject sound;


    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {

        
        GameObject soundfood = Instantiate(sound) as GameObject;

        righteffect.score = righteffect.score + 10;
        if (PlayerPrefs.GetInt("high", 0) < righteffect.score)
        {
            PlayerPrefs.SetInt("high", righteffect.score);
            GameObject hightext = GameObject.Find("Main Camera/Canvas/Hightext");
            Text myhightext = hightext.GetComponent<Text>();
            myhightext.text = PlayerPrefs.GetInt("high", 0).ToString();

        }
        GameObject scoretext = GameObject.Find("Main Camera/Canvas/Currenttext");
        Text myscoretext = scoretext.GetComponent<Text>();
        myscoretext.text = righteffect.score.ToString();


        Destroy(this.gameObject);
       


    }


    // Update is called once per frame
    void Update()
    {

    }
}
