using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyanimation : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(waiter());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator waiter()
    {
        yield return new WaitForSeconds(4);
        Destroy(this.gameObject);
    }
    
}
