using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrowthZone : MonoBehaviour
{
    public float growthRate = 0.1f; 

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           
            Vector3 currentScale = other.transform.localScale;
            other.transform.localScale = currentScale + Vector3.one * growthRate * Time.deltaTime;
        }
    }
}