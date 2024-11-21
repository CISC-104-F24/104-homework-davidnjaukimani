using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class printsInTheRed : MonoBehaviour
{
    private void OnTriggerStay(Collider other) 
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Debug.Log("YOU'RE IN THE RED");
        }
    }
}
