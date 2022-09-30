using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionsX : MonoBehaviour
{

    private void OnTriggerEnter(Collider other)
    {
        //este codigo es activado con el collider y el disparador
        // cuando chocan se destruye la bola 
        Destroy(gameObject);
    }
}
