using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokecareffect1 : MonoBehaviour
{
    public GameObject smoke1;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (collisioneffect.playerhealth == 2 && !appearobstaclewrong.isright)
        {
            GameObject smk1 = Instantiate(smoke1) as GameObject;
            smk1.transform.localScale = smk1.transform.localScale * 2;
        }
        
    }





    
    // Update is called once per frame
    void Update()
    {
        
    }
}
