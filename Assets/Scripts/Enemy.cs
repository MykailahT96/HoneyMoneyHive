using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    //public GameObject inventoryManager;
    public int health = 50;
    public Transform mainTower;
    public Rigidbody2D rb;
    public float waspSpeed = 0.05f;
    public Inventory inventoryScript;
    public float selfDestructTimer = 10f;

   // public GameObject deathEffect;
    void Start()
    {
        //inventoryScript = inventoryManager.GetComponent<Inventory>();
        FindHive();
        
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
        //rb.transform.position = new Vector3(transform.position.x + waspSpeed, transform.position.y);
    }
    public void TakeDamage(int damage)
    {
        //health -= damage;
        if(damage >= health)
        {
            FindObjectOfType<Inventory>().AddHoney(damage);
            health = 0;
            //inventoryScript.currentHoney += health;
            Debug.Log("Wasp HP: " + health);
            Die();
        }
        else
        {
            FindObjectOfType<Inventory>().AddHoney(damage);
            health -= damage;
            Debug.Log("Wasp HP: " + health);
            //inventoryScript.currentHoney += damage;
        }
    }

    void Die()
    {
        //Instantiate(deatheffect, transform.position, Quaternion.identity);
        Destroy(gameObject);
        FindObjectOfType<Inventory>().AddKill();
    }
    void SelfDestruct()
    {
        Destroy(gameObject);
    }

    void FindHive()
    {
        Vector2 target = FindObjectOfType<MainHive>().HiveLocation();
        //Vector2 target = new Vector2(transform.mainTower.position.x, transform.mainTower.position.y);
        Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 1);
        Vector2 direction = target - myPos;
        direction.Normalize();
        Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg);
        rb.velocity = direction * waspSpeed; 
    }
}

/*
        Vector2 target = new Vector2(transform.mainTower.position.x, transform.mainTower.position.y);
        Vector2 myPos = new Vector2(transform.position.x, transform.position.y + 1);
        Vector2 direction = target - myPos;
        direction.Normalize();
        Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg);
        rb.velocity = direction * speed; 
*/
