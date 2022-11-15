using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon2", menuName = "Weapon2")]
public class WeaponWithoutRB : ScriptableObject
{
    public Sprite currentWeaponSpr;

    public GameObject bulletPrefab;
    public float fireRate = 1f;
    public float damage = 20f;

    public void Shoot()
    {
        GameObject bullet = Instantiate(bulletPrefab, GameObject.Find("FirePoint").transform.position, Quaternion.identity);
    }
}
