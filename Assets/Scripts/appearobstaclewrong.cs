using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class appearobstaclewrong : MonoBehaviour
{
    public GameObject obstacleprefab;
    public float respawntime = 3.0f;
    

   
    public static bool isright = false;

    // Start is called before the first frame update
    void Start()
    {
        
        obstacleprefab.GetComponent<Rigidbody2D>().gravityScale = selectlevel.level;
        StartCoroutine(obstaclewave());
        GameObject hightext = GameObject.Find("Main Camera/Canvas/Hightext");
        Text myhightext = hightext.GetComponent<Text>();
        myhightext.text = PlayerPrefs.GetInt("high", 0).ToString();
    }

    private void spawnobst()
    {
        // initiate the text in the obstacles
        
        
        //initiate the text on top
        
        // random words definied in the function obstaclewave
        
        
        
        
        GameObject a = Instantiate(obstacleprefab) as GameObject;
        

        a.transform.position = new Vector2(Random.Range(-12.35f, 12.36f), 10f);
        
    }
    // Update is called once per frame
    void Update()
    {
        

     }

    IEnumerator obstaclewave()
    {
        
        respawntime = 3.0f ;
        while (collisioneffect.playerhealth >= 1)
        {
            // object is wrong by deafault
            isright = false;
            // 4 rounds 
            
            // j is numer of times objects 
            int j = 4;
            for (int i = 1; i <= j; i++)
            {
                
                
                // calculate probability of being righ and assign
                // variable to calculate prob
                int prob = Random.Range (1, 11);
                // 50% chance of beeing right
                if (prob >= 6)
                {
                    isright = true;
                }
                // if it is last for loop must be equal
                else
                {
                    isright = false;
                }
                // wait and make object
                
                spawnobst();
                // check if indexes are equal to see if object is right
                
                //must wait after so there is time for the isright to be true
                yield return new WaitForSeconds(respawntime);
                // break must be after the wait
                if (isright)
                {
                    break;

                }


            }
        }
    }
}

