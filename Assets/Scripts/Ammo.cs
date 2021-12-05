using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    public GameManager gameManagerScript;
    public Transform firepoint;
    public GameObject bulletPrefab;
    public bool gameInPlay = true;
    public int bulletDamage = 40;

    // Update is called once per frame
    void Start()
    {
        PlayerPrefs.SetInt("bulletDamage", bulletDamage);
    }
    void Update()
    {
        if(Input.GetButtonDown("Fire2"))
        {
           Shoot();
        }

    }

    void Shoot()
    {
        Instantiate(bulletPrefab, firepoint.position, firepoint.rotation);
    }

    public void ActiveShooting(bool shooting)
    {
        gameInPlay = shooting;
    }
    public void UpgradeDamage(int newDamage)
    {
        bulletDamage = bulletDamage + newDamage;
        Debug.Log("New damage amount: " + bulletDamage);
        PlayerPrefs.SetInt("bulletDamage", bulletDamage);
    }
}
