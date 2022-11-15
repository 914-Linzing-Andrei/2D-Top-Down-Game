using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class EnemySpawner : MonoBehaviour
{
    //public float xBound, yBound;
    public GameObject[] enemies;

    void Start()
    {
        StartCoroutine(SpawnAnEnemy());
    }

    [SerializeField]
    public float time1 = 0.2f;
    public float time2 = 2f;

    IEnumerator SpawnAnEnemy()
    {
        GameObject timer = GameObject.Find("Text");
        timerUP timerup = timer.GetComponent<timerUP>();
        int timee = Convert.ToInt32(timerup.textBox.text);
        if(timee % 20 == 0 && timee > 0)
            time1 += 0.3f;
        //Debug.Log(timee);

        yield return new WaitForSeconds(UnityEngine.Random.Range(time1, time2));

        Vector2 spawnPoint = new Vector2(UnityEngine.Random.Range(-23.49f, 35.48f), UnityEngine.Random.Range(-29.45f, 29.52f));
        Instantiate(enemies[UnityEngine.Random.Range(0, enemies.Length)], spawnPoint, Quaternion.identity);

        StartCoroutine(SpawnAnEnemy());
    }
}
