using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroyer : MonoBehaviour
{
    public string excludeTag = "Player";

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag(excludeTag))
        {
            Destroy(collision.gameObject);
        }
    }


}
