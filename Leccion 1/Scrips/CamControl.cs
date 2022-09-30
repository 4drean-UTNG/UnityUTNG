using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamControl : MonoBehaviour
{
    public GameObject Tanque;
    public Vector3 upCam = new Vector3(0,10,-10);
    // no se ejecuta nada al inicio
    void Start()
    {
        
    }

    // este codigo se relaciona con la camara y sigue el objeto tanque
    void Update()
    {
        //se mueve la camara siguiendo al tanque
        transform.position = Tanque.transform.position+upCam;
    }
}
