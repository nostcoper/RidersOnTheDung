using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMenu : MonoBehaviour
{
    public float rotationSpeed = 10.0f;

    void Update()
    {
        // Rotar el objeto vacío alrededor de su propio eje Y
        transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
    }
}
