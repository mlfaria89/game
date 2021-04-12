using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class appearobstaclewrong : MonoBehaviour
{
    public GameObject obstacleprefab;
    public float respawntime = 3.0f;
    

    int index1 = 0;
    int index2 = 0;
    public static bool isright = false;

    // Start is called before the first frame update
    void Start()
    {
      
        StartCoroutine(obstaclewave());
        
    }

    private void spawnobst()
    {
        // initiate the text in the obstacles
        
        
        //initiate the text on top
        
        // random words definied in the function obstaclewave
        
        
        
        
        GameObject a = Instantiate(obstacleprefab) as GameObject;
        

        a.transform.position = new Vector2(Random.Range(-4.35f, 4.36f), 10f);
        
    }
    // Update is called once per frame
    void Update()
    {
        

     }

    IEnumerator obstaclewave()
    {
        
        respawntime = 3.0f;
        while (collisioneffect.playerhealth >= 1)
        {
            // object is wrong by deafault
            isright = false;
            // 4 rounds of the word on top and the other words random
            index1 = Random.Range(0, 3);
            // j is numer of times objects are created within the same word in english
            int j = 4;
            for (int i = 1; i <= j; i++)
            {
                
                index2 = Random.Range(0, 3);
                // calculate probability of being righ and assign
                // variable to calculate prob
                int prob = Random.Range (1, 11);
                // 30% chance of beeing equal
                if (prob >= 8)
                {
                    index2 = index1;
                }
                // if it is last for loop must be equal
                if (i == j)
                {
                    index2 = index1;
                }
                // wait and make object
                
                spawnobst();
                // check if indexes are equal to see if object is right
                if (index2 == index1)
                {
                    isright = true;
                    
                }
                //must wait after so there is time for the isright to be true
                yield return new WaitForSeconds(respawntime);
                // break must be after the wait
                if (index1 == index2)
                {
                    break;

                }


            }
        }
    }
}

