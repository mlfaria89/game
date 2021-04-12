using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokeonthecar : MonoBehaviour
{
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        GameObject player = GameObject.Find("player");
        transform.position = player.transform.position;
    }
}
