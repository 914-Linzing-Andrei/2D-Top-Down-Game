using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    public float health;
    [SerializeField]
    public int scoreYield;
    

    public float nr = 0;
    // Update is called once per frame
    void Update()
    {
        if (health < 1)
        {
            Score.scoreValue += scoreYield;
            Destroy(gameObject);
            nr += scoreYield;
        }
    }
    /*void OnCollisionEnter2D(Collision2D other)
    {
        if (health > 0)
        {
            health -= GameObject.Find("Player").GetComponent<Player>().currentWeapon.damage;
            
        }
        if(health == 0)
            Destroy(other.gameObject);
    }*/
    void OnTriggerEnter2D(Collider2D target)
    {
        if(target.tag == "YellowBullet")
        {
            health -= GameObject.Find("Player").GetComponent<Player>().currentWeapon.damage;
            Destroy(target.gameObject);
        }
    }
}
