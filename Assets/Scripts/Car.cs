using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    
    public Rigidbody2D rb;

    void Start()
    {
	    GameManager.speed = Random.Range(GameManager.minSpeed, GameManager.maxSpeed);
        Destroy(gameObject, 3f);
    }

    void FixedUpdate()
    {
	    Vector2 forward = new Vector2(transform.right.x, transform.right.y);
	    rb.MovePosition(rb.position + forward * Time.fixedDeltaTime * GameManager.speed);    
    }
}
