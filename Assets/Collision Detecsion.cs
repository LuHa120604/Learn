using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetecsion : MonoBehaviour
{
    public float radius;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("OnTrigerEnter" + other.name);
    }
    private void OnTriggerStay(Collider other)
    {
        Debug.Log("OnTrigerStay" + other.name);
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("OnTrigerExit" + other.name);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("OnCollisionEnter");
    }
    private void OnCollisionStay(Collision collision)
    {
        Debug.Log("OnCollisionStay" );
    }
    private void OnCollisionExit(Collision collision)
    {
        Debug.Log("OnCollisionExit" );
    }
}
