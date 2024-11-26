using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthScirpts : MonoBehaviour
{
    void OnTriggerEnter2D (Collider2D other)
    {

        PlayerController controller = other.GetComponent<PlayerController>();
           
          

    }
       
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
