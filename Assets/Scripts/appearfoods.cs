using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class appearfoods : MonoBehaviour
{
    public GameObject bearprefab;
    public GameObject sausageprefab;
    public GameObject pretzelprefab;

    public float respawntime = 3.0f;
    

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(obstaclewave());
    }

    private void spawnfood()
    {
        
        int i = Random.Range(1, 4);
        if (i == 1)
        {
            GameObject a = Instantiate(bearprefab) as GameObject;
            a.transform.position = new Vector2(Random.Range(-4.35f, 4.36f), 10f);
        }

        if (i == 2)
        {
            GameObject b = Instantiate(sausageprefab) as GameObject;
            b.transform.position = new Vector2(Random.Range(-4.35f, 4.36f), 10f);
        }

        if (i == 3)
        {
            GameObject c = Instantiate(pretzelprefab) as GameObject;
            c.transform.position = new Vector2(Random.Range(-4.35f, 4.36f), 10f);
        }

        

    }
    // Update is called once per frame
    void Update()
    {

    }

    IEnumerator obstaclewave()
    {
        yield return new WaitForSeconds(1.5f);
        respawntime = 6.0f;
        while (collisioneffect.playerhealth>=1)
        {
            
            

                

                spawnfood();
                
                
                
                yield return new WaitForSeconds(respawntime);
                // break must be after the wait
                


         }
        
    }
}