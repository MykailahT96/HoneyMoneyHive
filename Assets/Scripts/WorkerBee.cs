using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WorkerBee : MonoBehaviour
{
   public float speed = 1.5f;
   public Vector3 target;

    void Start()
    {
        target = transform.position;
    }


    // Update is called once per frame
    void Update()
    {
        //if bee is selected

        if (Input.GetMouseButtonDown(0))
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            target.z = transform.position.z;
        }
        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
/*
void Update() {  
    if (Input.GetMouseButtonDown(0)) 
    {  
      Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);  
      RaycastHit hit;  
      if (Physics.Raycast(ray, out hit)) 
      {  
  
        //Select stage    
        if (hit.transform.name == "Sphere") 
        {  
          SceneManager.LoadScene("SceneOne");  
        }
*/
