using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class foodsmove : MonoBehaviour
{
    public static float speed = 10.0f;
    private Rigidbody2D rb;
    private bool seen = false;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, -speed);

    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Renderer>().isVisible)
        {
            seen = true;
        }
        if (seen && !GetComponent<Renderer>().isVisible)
        {
            Destroy(gameObject);
        }
        if (collisioneffect.playerhealth<1)
        {
            Destroy(gameObject);
        }
    }
}
