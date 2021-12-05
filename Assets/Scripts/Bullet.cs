using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20f;
    public int damage;
    public Rigidbody2D rb;
    public float selfDestructTimer = 0f;
    //public GameObject impactEffect;

    
    // Start is called before the first frame update
    void Start()
    {
        //rb.velocity = transform.forward * speed;
        
        selfDestructTimer = 5f;
        Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
        Vector2 myPos = new Vector2(transform.position.x, transform.position.y);
        Vector2 direction = target - myPos;
        direction.Normalize();
        Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg);
        rb.velocity = direction * speed; 
        Debug.Log("Current bullet damage: " + PlayerPrefs.GetInt("bulletDamage"));
        damage = PlayerPrefs.GetInt("bulletDamage");
    }

    void Update()
    {
        if(selfDestructTimer > 0)
        {
            selfDestructTimer -= Time.deltaTime;
        }
        else
        {
            SelfDestruct();
        }
    }

    void OnTriggerEnter2D(Collider2D hitInfo)
    {
        Enemy enemy = hitInfo.GetComponent<Enemy>();
        Flower flower = hitInfo.GetComponent<Flower>();
        if(enemy != null)
        {
            Debug.Log("Hit wasp");
            enemy.TakeDamage(damage);
        }
        else if(flower != null)
        {
            Debug.Log("Hit flower");
            flower.CollectNectar(damage);
            
        }
        //Instantiate(impactEffect, transform.position, transform.rotation);
        //Debug.Log();
    }

    void SelfDestruct()
    {
        Destroy(gameObject);
    }


}
/*
    if (Input.GetMouseButtonDown(0))
        {
            Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 1);
            Vector2 direction = target - myPos;
            direction.Normalize();
            Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg);
            GameObject projectile = (GameObject)Instantiate(bullet, myPos, rotation);
            projectile.GetComponent<Rigidbody2D>().velocity = direction * speed;
        }
*/
