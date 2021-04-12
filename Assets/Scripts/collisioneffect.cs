using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class collisioneffect : MonoBehaviour
{

    public GameObject explosion;
    public static int playerhealth = 3;
    public static bool gameover = false;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    private void OnTriggerEnter2D(Collider2D other)
    {
        
        if (appearobstaclewrong.isright)
        {
            Debug.Log("hit right");
            
        } else
        {
            GameObject e = Instantiate(explosion) as GameObject;
            e.transform.position = transform.position;
            e.transform.localScale = e.transform.localScale * 2;
            Debug.Log("hit wrong");
            playerhealth = playerhealth - 1;
            

        }

        if (playerhealth < 1)
        {
            Debug.Log("you died");
            int lives = PlayerPrefs.GetInt("lives", 2);
            lives = lives - 1;
            PlayerPrefs.SetInt("lives", lives);
            Debug.Log("you have" + lives + "lives left");
            GameObject ebig = Instantiate(explosion) as GameObject;
            ebig.transform.position = transform.position;
            ebig.transform.localScale = ebig.transform.localScale * 8;
            gameover = true;
            
            
            
        }
        
        Destroy(this.gameObject);

        
    }

    
   

    // Update is called once per frame
    void Update()
    {
        
    }
}
