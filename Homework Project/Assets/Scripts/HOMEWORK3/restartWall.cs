using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartOnCollision : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        // Restart the scene when a collision happens
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}