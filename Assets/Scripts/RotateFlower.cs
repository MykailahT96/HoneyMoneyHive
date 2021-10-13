using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateFlower : MonoBehaviour
{
    public float spinSpeed = 50f;
    void Update()
    {
        transform.Rotate(0f, 0f, (spinSpeed * Time.deltaTime));

    }
}
