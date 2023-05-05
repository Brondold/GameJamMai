using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateCamera : MonoBehaviour
{
    public float rotationSpeed = 1f;
    public float targetRotation = 90f; // Rotation cible en degrés
    public float targetRotationLeft = -90f; // Rotation cible en degrés
    public float smoothTime = 0.3f; // Durée de l'effet smooth

    private float currentRotation = 0f;
    private bool isRotating = false;
    private bool isRotatingLeft = false;

    public void Rotate()
    {
        isRotating = true;
    }

    public void RotateLeft()
    {
        isRotatingLeft = true;
    }
    void Update()
    {
        if (isRotating)
        {
            Quaternion target = Quaternion.Euler(0f, targetRotation + currentRotation, 0f);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, target, rotationSpeed * Time.deltaTime);

            if (transform.rotation == target)
            {
                currentRotation += targetRotation;
                isRotating = false;
            }
        }

        if (isRotatingLeft)
        {
            Quaternion target = Quaternion.Euler(0f, targetRotationLeft + currentRotation, 0f);
            transform.rotation = Quaternion.RotateTowards(transform.rotation, target, rotationSpeed * Time.deltaTime);

            if (transform.rotation == target)
            {
                currentRotation += targetRotationLeft;
                isRotatingLeft = false;
            }
        }
    }
}
