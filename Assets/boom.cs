using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class boom : MonoBehaviour
{
    public float timeToExpl;
    public float power;
    public float radius;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timeToExpl -= Time.deltaTime;

        if (timeToExpl <= 0)
        {
            Boom();
        }
    }

    void Boom()
    {
        Rigidbody[] blocks = FindObjectsOfType<Rigidbody>();

        foreach (Rigidbody B in blocks)
        {
            if(Vector3.Distance(transform.position, B.transform.position) < radius)
            {
                Vector3 direction = B.transform.position - transform.position;

                B.AddForce(direction.normalized * power * (radius - Vector3.Distance(transform.position, B.transform.position)), ForceMode.Impulse);
            }
        }

        timeToExpl= 3;
    }
}
