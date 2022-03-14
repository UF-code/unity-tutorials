using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delivery : MonoBehaviour
{
    bool hasPackage;
    [SerializeField] float delayDisappear = 0.5f;

    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("Ouch!");
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && !hasPackage)
        {
            Debug.Log("Package Picked Up!");
            hasPackage = !hasPackage;
            Destroy(other.gameObject, delayDisappear);
        }
        else if (other.tag == "Customer" && hasPackage)
        {
            Debug.Log("Package Delivered!");
            hasPackage = !hasPackage;
        }
    }
}
