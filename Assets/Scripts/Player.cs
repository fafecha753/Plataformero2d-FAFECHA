using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed;
    private float horizontal;
    private Rigidbody2D rb2d;

    // Start is called before the first frame update
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horizontal = Input.GetAxis("Horizontal") * speed;
        if (horizontal < 0.0f)
        {
            transform.localScale = new Vector2(-1.0f, 1.0f);
        }else if(horizontal > 0.0f)
        {
            transform.localScale = new Vector2(1.0f,1.0f);
        }
    }
    private void FixedUpdate()
    {
        rb2d.velocity = new Vector2(horizontal, rb2d.velocity.y);
    }

}
