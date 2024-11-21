using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintObject : MonoBehaviour
{
    // The color to apply to touched objects
    public Color paintColor = Color.red;

    public Color whitePaint = Color.white;

    private void OnCollisionStay(Collision collision)
    {
        
        // Continuously paint while touching
        Renderer objectRenderer = collision.gameObject.GetComponent<Renderer>();
        if (!collision.gameObject.CompareTag("Player") && objectRenderer != null && !collision.gameObject.CompareTag("wall") && !collision.gameObject.CompareTag("paintSphere"))
        {
            objectRenderer.material.color = paintColor;
        }
    }
    private void OnCollisionExit(Collision collision)
    {
        // Get the renderer of the object we collided with
        Renderer objectRenderer = collision.gameObject.GetComponent<Renderer>();

        // If the object has a renderer, change its color

        if (!collision.gameObject.CompareTag("Player") && objectRenderer != null && !collision.gameObject.CompareTag("wall") && !collision.gameObject.CompareTag("paintSphere"))
        {

            objectRenderer.material.color = whitePaint;
        }
    }
}
