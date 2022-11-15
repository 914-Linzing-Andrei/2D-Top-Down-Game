using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DebugHit : MonoBehaviour
{
    void OnCollisionEnter2D(Collision2D collider)
    {
        Debug.Log("Hit");
    }
}
