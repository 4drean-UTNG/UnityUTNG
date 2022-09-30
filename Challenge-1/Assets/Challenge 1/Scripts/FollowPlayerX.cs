using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayerX : MonoBehaviour
{
    public GameObject plane;
    private Vector3 offset=new Vector3(20,2,0);

    //No se ejecuta nada al inicio 
    void Start()
    {

    }

    // aqui seguimos un objeto,en este caso la avioneta con la camara
    void Update()
    {
        transform.position = plane.transform.position + offset;
    }
}
