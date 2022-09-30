using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCarne : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // se ejecuta en cada frame
    void Update()
    {

        // se destruye la carne cuando sobrepasa el limite 
        if(transform.position.z>35){
            Destroy(gameObject);
        }
        //se transporta el alimento 
        transform.Translate(Vector3.forward*Time.deltaTime*20);
        
    }
}
