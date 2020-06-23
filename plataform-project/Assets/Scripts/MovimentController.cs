using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Collider2D), typeof(Rigidbody2D))]
public class MovimentController : MonoBehaviour
{
    new private Collider2D collider;
    private Rigidbody2D rb;

    private bool lookBackwards;
    private void Awake()
    {
        collider = GetComponent<Collider2D>();
        rb = GetComponent<Rigidbody2D>();
    }
 

    public void Move(float velocity)
    {
        rb.velocity = new Vector2(velocity, rb.velocity.y);
        if (velocity < 0 && !lookBackwards)
            Flip(true);
        else if (velocity > 0 && lookBackwards)
            Flip(false);
    }  
    public void Flip(bool turnLeft)
    {
        lookBackwards = !lookBackwards;
        transform.localScale = new Vector3(turnLeft ? 1 : -1, 1, 1);
    }
}
