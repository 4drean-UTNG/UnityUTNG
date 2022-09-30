using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public float speed;
    public float rotationSpeed;
    public float verticalInput;

    // Start is called before the first frame update
    void Start()
    {

    }

    // esto se ejecuta por cada frame
    void FixedUpdate()
    {
        // se ingresa el movimiento en teclas de arriba y abajo
        verticalInput = Input.GetAxis("Vertical");

        // se realiza la traslacion de la avioneta para enfrente 
        transform.Translate(Vector3.forward * speed* Time.deltaTime);

        // aqui se mueve la avioneta trasladandola para arriba o para abajo la
        //dependiendo de la tecla que su valor se guarda en verticalInput
        transform.Rotate(Vector3.left * rotationSpeed * Time.deltaTime*verticalInput);
    }
}
