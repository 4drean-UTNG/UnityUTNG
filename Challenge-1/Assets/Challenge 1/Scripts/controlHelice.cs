using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controlHelice : MonoBehaviour
{
    public float velGiro=1000.0f;
    // este metodo se ejecuta solo una vez al inicio
    void Start()
    {
        
    }

    // aqui se genera la rotacion de la helice
    void Update()
    {
        transform.Rotate(Vector3.forward*velGiro*Time.deltaTime);
    }
}
