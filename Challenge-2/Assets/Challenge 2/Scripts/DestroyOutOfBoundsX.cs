using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyOutOfBoundsX : MonoBehaviour
{
    private float leftLimit = -30;
    private float bottomLimit = -5;

    // este codigo actualiza destruyendo el objeto prefab cuando sobre pasa el limite
    void Update()
    {
        // si el perro sobrepasa el limite se destruye 
        if (transform.position.x < leftLimit)
        {
            Destroy(gameObject);
        } 
        // si las pelotas sobre pasan el limite, se eliminan
        else if (transform.position.y < bottomLimit)
        {
            Destroy(gameObject);
        }

    }
}
