using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerControler : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject proyectilCarne;
    float horInput;

    float limit=20;

    void Start()
    {
        
    }

    // se ejecuta en cada frame
    void Update()
    {   
        // aqui se pone como limite hasta donde se puede mover nuestro sujeto
        if(transform.position.x>limit){
            //transportamos a nuestro humano 
            transform.position=new Vector3(limit
            ,transform.position.y,transform.position.z);
        }
        if(transform.position.x<-limit){
            //transportamos a nuestro humano 
            transform.position=new Vector3(-limit
            ,transform.position.y,transform.position.z);
        }
        //se ejecuta cuando precionamos la tecla de espacio
        if (Input.GetKeyDown(KeyCode.Space)){
            //se crea la carne que se mueve para destruir a los animales
            Instantiate(proyectilCarne,transform.position,
            proyectilCarne.transform.rotation);
        }
        //se mueve de forma horizontal nuestro humano
        horInput =Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right*Time.deltaTime*20*horInput);
    }
}
