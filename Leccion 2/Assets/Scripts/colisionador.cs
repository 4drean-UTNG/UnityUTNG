using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colisionador : MonoBehaviour
{
  
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    //este codigo e ejecuta cuando choca un animal con el alimento
    void OnTriggerEnter(Collider other){
        //se destruye el objeto animal 
     Destroy(gameObject);
     Destroy (other.gameObject);
    }
}
