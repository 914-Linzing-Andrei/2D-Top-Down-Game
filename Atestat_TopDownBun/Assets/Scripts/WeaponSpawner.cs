using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponSpawner : MonoBehaviour
{
    public GameObject[] weapons;

    void Start()
    {
        StartCoroutine(SpawnAWeapon());
    }

    IEnumerator SpawnAWeapon()
    {
        yield return new WaitForSeconds(3f);
        Vector2 spawnPoint = new Vector2(Random.Range(-23.49f, 35.48f), Random.Range(-29.45f, 29.52f));
        if(GameObject.FindGameObjectsWithTag("Weapon").Length < 5)
        Instantiate(weapons[Random.Range(0, weapons.Length)], spawnPoint, Quaternion.identity);
        StartCoroutine(SpawnAWeapon());
    }
}
