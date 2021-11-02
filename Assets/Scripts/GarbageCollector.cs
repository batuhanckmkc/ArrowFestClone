using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GarbageCollector : MonoBehaviour
{
    protected static float garbageCollectorSpeed;
    Rigidbody rigid;

    void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        rigid.velocity = (Vector3.forward * Time.deltaTime * -garbageCollectorSpeed);
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.gameObject.tag == "ninjaMan")
        {
            Destroy(collider.gameObject);
        }
        if (collider.gameObject.tag == "Walls")
        {
            Destroy(collider.gameObject);
        }
        if (collider.gameObject.tag == "Player")
        {
            Destroy(gameObject);
        }

    }
}
