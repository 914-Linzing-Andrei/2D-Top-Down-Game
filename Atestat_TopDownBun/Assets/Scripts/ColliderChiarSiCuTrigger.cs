using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderChiarSiCuTrigger : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.gameObject.CompareTag("Player"))
        {
            Player moveScript = target.GetComponent<Player>();
            moveScript.moveSpeed = 1f;
        }
    }
    void OnTriggerExit2D(Collider2D target)
    {
        if(target.gameObject.CompareTag("Player"))
        {
            Player moveScript = target.GetComponent<Player>();
            moveScript.moveSpeed = 5f;
        }
    }
}
