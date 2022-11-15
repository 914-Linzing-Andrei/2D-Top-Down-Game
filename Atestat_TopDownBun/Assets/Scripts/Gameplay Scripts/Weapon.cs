using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Weapon", menuName = "Weapon")]
public class Weapon : ScriptableObject
{
    public Sprite currentWeaponSpr;

    public GameObject bulletPrefab;
    public float fireRate = 1;
    public float damage = 20f;

    public float bulletForce = 20f;

    public void Shoot()
    {
        Instantiate(bulletPrefab, GameObject.Find("FirePoint").transform.position, Quaternion.identity);
            //Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
            //rb.AddForce(GameObject.Find("FirePoint").transform.up * bulletForce, ForceMode2D.Impulse);
    }
}
