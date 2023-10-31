using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hazard : MonoBehaviour
{
    public float patrolSpeed = 1f;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        int i = 25;
        while (i < 26)
        {
            rb.velocity = new Vector2((1f * patrolSpeed), 0f);
            i--;
        }
    }
}
