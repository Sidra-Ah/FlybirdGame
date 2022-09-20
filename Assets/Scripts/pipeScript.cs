using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeScript : MonoBehaviour
{
    public float speed;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed);
    //    rb.velocity = Vector2.left * speed;
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        if(collision.gameObject.tag == "endpipe")
        {
            Destroy(gameObject);
        }
    }
}
