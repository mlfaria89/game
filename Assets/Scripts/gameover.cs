using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameover : MonoBehaviour
    
{
    
    public GameObject darkscreen;
    // Start is called before the first frame update
    void Start()
    {
        
    }

   

    // Update is called once per frame
    void Update()
    {
        if (collisioneffect.gameover)
        {
            // create a dark screen
            GameObject Im = Instantiate(darkscreen) as GameObject;
            Im.transform.SetParent(GameObject.Find("Main Camera/Canvas").transform);
            collisioneffect.gameover = false;
            GameObject p = GameObject.Find("player");
            p.transform.position = new Vector3(0,-30,0);
            AudioSource audio = p.GetComponent<AudioSource>();
            audio.Pause();
            Invoke("Changescene", 3.0f);
            
            
            
        }
    }

    void Changescene()
    {
        if (righteffect.score > PlayerPrefs.GetInt("high", 0))
        {
            PlayerPrefs.SetInt("high", righteffect.score);
        }
        SceneManager.LoadScene("GameOver");
        collisioneffect.playerhealth = 3;
        righteffect.score = 0;
    }
}
