using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletWithoutEffect : MonoBehaviour
{
    private float speed = 5f;

    private Vector2 dir;

    void Start()
    {
        dir = GameObject.Find("Dir").transform.position;
        transform.position = GameObject.Find("FirePoint").transform.position;
    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, dir, speed * Time.deltaTime);
    }
}
