using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubdividePlane : MonoBehaviour
{
    public int subdivisions = 100; // Number of subdivisions
    public float planeSize = 100f; // plne length

    void Start()
    {
        Subdivide();
    }

    void Subdivide()
    {
        float subPlaneSize = planeSize / subdivisions;

        // Create a parent object
        GameObject parentObject = new GameObject("SubdividedPlane");
        parentObject.transform.position = this.transform.position;
        parentObject.transform.rotation = this.transform.rotation;

        for (int x = 0; x < subdivisions; x++)
        {
            for (int z = 0; z < subdivisions; z++)
            {
                // Calculate position of each sub-plane
                Vector3 position = new Vector3(
                    (x * subPlaneSize) - (planeSize / 2) + (subPlaneSize / 2),
                    0,
                    (z * subPlaneSize) - (planeSize / 2) + (subPlaneSize / 2)
                );

                // Creates  sub-planes
                GameObject subPlane = GameObject.CreatePrimitive(PrimitiveType.Plane);
                subPlane.transform.localScale = new Vector3(subPlaneSize / 10, 1, subPlaneSize / 10);
                subPlane.transform.position = position;
                subPlane.transform.parent = parentObject.transform;

               
                
            }
        }

        //  hide the original plane
        this.gameObject.SetActive(false);
    }
}
