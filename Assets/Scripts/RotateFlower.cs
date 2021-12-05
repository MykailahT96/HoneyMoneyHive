using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFlower : MonoBehaviour
{
    public float spinSpeed = 50f;
    public Transform flower;    
    void Update()
    {
        flower.transform.Rotate(0f, 0f, (spinSpeed * Time.deltaTime));

    }
}
