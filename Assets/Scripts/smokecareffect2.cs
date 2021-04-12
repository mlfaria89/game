using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smokecareffect2 : MonoBehaviour
{
    public GameObject smoke2;
    // Start is called before the first frame update
    void Start()
    {

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (collisioneffect.playerhealth == 1 && !appearobstaclewrong.isright)
        {
            GameObject smk2 = Instantiate(smoke2) as GameObject;
            smk2.transform.localScale = smk2.transform.localScale * 1;
        }

    }






    // Update is called once per frame
    void Update()
    {

    }
}
