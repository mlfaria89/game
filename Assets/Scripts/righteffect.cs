using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class righteffect : MonoBehaviour
{

    public GameObject shatter;
    public static int score=0;
    
    
    


    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (appearobstaclewrong.isright)
        {
            GameObject ebig = Instantiate(shatter) as GameObject;
            ebig.transform.position = transform.position;
            ebig.transform.localScale = ebig.transform.localScale * 8;
            score = score + 50;
            if (PlayerPrefs.GetInt("high",0) < score)
                {
                PlayerPrefs.SetInt("high", score);
                GameObject hightext = GameObject.Find("Main Camera/Canvas/Hightext");
                Text myhightext = hightext.GetComponent<Text>();
                myhightext.text = PlayerPrefs.GetInt("high",0).ToString();
                
            }
            Debug.Log(score.ToString());
            GameObject scoretext = GameObject.Find("Main Camera/Canvas/Currenttext");
            Text myscoretext = scoretext.GetComponent<Text>();
            myscoretext.text = score.ToString();
            
        }
        

        


    }


    // Update is called once per frame
    void Update()
    {

    }
}
