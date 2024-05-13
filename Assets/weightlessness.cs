using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weightlessness : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Object entered trigger");
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.useGravity = false;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        Debug.Log("Object exited trigger");
        Rigidbody rb = other.GetComponent<Rigidbody>();
        if (rb != null)
        {
            rb.useGravity = true;
        }
    }

}
