using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gravity : MonoBehaviour
{
    private void FixedUpdate()
    {
        float gravityStrength = 1;
        Vector2 gravityVelocity = gravityStrength * Physics2D.gravity * Time.deltaTime;
        Vector2 deltaPosition = Physics2D.gravity * Time.deltaTime;
    }
}
