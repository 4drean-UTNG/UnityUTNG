using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour
{
    //se inician las variables de velocidad y giro 
    public float velocidad=20;
    public float velGiro=20;
    private float avanza;
    private float gira;
    // no se ejecuta nada al inicio
    void Start()
    {
        
    }

    // Aqui se mueve nuestro tanque  con las teclas 
    void Update()
    {
        //se asigna a las variables el valor que se genera con las teclas
        gira= Input.GetAxis("Horizontal");
        avanza = Input.GetAxis("Vertical");
        //se hace la traslacion del tanque dependiendo de las variables de avanzar o rotar
        transform.Translate(Vector3.forward*Time.deltaTime*velocidad*avanza);
        transform.Rotate(Vector3.up, Time.deltaTime*velGiro*gira);
    }
}