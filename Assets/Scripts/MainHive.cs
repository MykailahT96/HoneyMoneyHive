using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainHive : MonoBehaviour
{
    public Transform hive;
    public Vector2 hiveLocation;
    
    // Start is called before the first frame update
    void Start()
    {
        Vector2 hiveLocation = new Vector2(hive.transform.position.x, hive.transform.position.y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Vector2 HiveLocation()
    {
        return hiveLocation;
    }
}
