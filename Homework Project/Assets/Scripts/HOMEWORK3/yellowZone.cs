using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class destroyOnEntry : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.CompareTag("Player"))
        {
            Destroy(other.gameObject);
        }
    }
}

