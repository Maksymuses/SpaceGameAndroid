﻿using UnityEngine;

public class BossBullet2 : MonoBehaviour {

    Rigidbody2D myRigidbody2D;
    public float moveSpeed;

    void Start()
    {
        myRigidbody2D = GetComponent<Rigidbody2D>();
        myRigidbody2D.AddRelativeForce(Vector2.down * moveSpeed, ForceMode2D.Impulse);
        myRigidbody2D.AddRelativeForce(Vector2.left * moveSpeed / 3.5f, ForceMode2D.Impulse);
    }
    void Update()
    {
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}
