using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisiWall: MonoBehaviour
{
    public string excludeTag = "Player";

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.gameObject.CompareTag(excludeTag))
        {
            collision.gameObject.SetActive(false);
        }
    }


}
