using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveAnimal : MonoBehaviour
{
    // se declara el limite 
    float limit=-14;
    void Start()
    {
        
    }

    // se ejecuta cada frame
    void Update()
    {
        // se elimina el animal cuando sobrepasa el limite
        if(transform.position.z<limit){
            Destroy(gameObject);
        }
        //se transporta el objeto del anima
        transform.Translate(Vector3.forward*Time.deltaTime*15);

        
    }
}
