using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Searching : MonoBehaviour
{
    

}

/*
    private float latestDirectionChangeTime;
    private readonly float directionChangeTime = 3f; 
    private float characterVelocity = 2f; //Random.Range(0.5f, 3f);
    private Vector3 movementDirection;
    private Vector3 movementPerSecond;
    public GameObject bee;
    public float rotationSpeedMultiplier = 20f;

    void Start()
    {
        latestDirectionChangeTime = 0f;
        calculateNewMovementVector();
    }

    void calculateNewMovementVector()
    {
        //create a random direction vector with magnitude of 1, 
        // later multiply it with the velocity of the enemy

        movementDirection = new Vector3(Random.Range(-1.0f, 1.0f), 0, Random.Range(-1.0f, 1.0f)).normalized;
        movementPerSecond = movementDirection * characterVelocity;
    }

    void Update()
    {
        //if the changeTime was reached, calculate a new mov vector
        if(Time.time - latestDirectionChangeTime > directionChangeTime)
        {
            latestDirectionChangeTime = Time.time;
            calculateNewMovementVector();
        }
        
        //move bee
        transform.position = new Vector3(transform.position.x + (movementPerSecond.x * Time.deltaTime), 22.45f, transform.position.z + (movementPerSecond.z * Time.deltaTime));
        
        bee.transform.rotation = Quaternion.Slerp(bee.transform.rotation, Quaternion.LookRotation(movementDirection), Time.deltaTime * rotationSpeedMultiplier);
    }
*/