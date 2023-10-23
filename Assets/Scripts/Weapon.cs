using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public GameObject bulletSpawn;
    public float fireRate;
    public float bulletDmg;
    public bool fromPlayer = false;
    public float cooldown = 0.9f;

    public void Update()
    {
        if (fromPlayer)
        {
            if (Input.GetButtonDown("Fire1"))
            {
                BulletSpawn();
            }
        }
        else {
            if (cooldown <= 0)
            {
                BulletSpawn();
                cooldown = 0.5f;
            }
            else
            {
                cooldown -= Time.deltaTime;
            }
        }
    }

    public void BulletSpawn()
    {
        GameObject bulletClone = Instantiate(bullet, bulletSpawn.transform.position, bulletSpawn.transform.rotation);
        bulletClone.GetComponent<Bullet>().bulletDmg = bulletDmg;
        bulletClone.GetComponent<Rigidbody>().AddForce(bulletSpawn.transform.forward * fireRate);
    }
}
