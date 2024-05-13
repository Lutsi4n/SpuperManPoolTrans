using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class power : MonoBehaviour
{
    public float launchForce = 20f; 

    void Start()
    {
        Rigidbody rb = GetComponent<Rigidbody>(); 

        if (rb != null) 
        {
            Vector3 launchDirection = transform.forward; 
            rb.AddForce(launchDirection * launchForce, ForceMode.Impulse); 
        }
    }
}
