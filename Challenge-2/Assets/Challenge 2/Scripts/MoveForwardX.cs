using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveForwardX : MonoBehaviour
{
    public float speed;

    // aqui se transporta al generar un perro
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
