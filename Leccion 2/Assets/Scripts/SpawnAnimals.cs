using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAnimals : MonoBehaviour
{
    public GameObject[] arrAnimal;
    // esto se ejecuta por primera vez al inicio
    void Start()
    {
        //se incoca la creacion del animal
        InvokeRepeating("CreateAnimal",1.5F,1.5F);
    }

    void Update()
    {
        
    }
    void CreateAnimal()
    {
        // se crea un animal dependiendo del numero random que salgan
        //este numero esta en un rango de los animales que hay 
        int aleatorio=Random.Range(0,3);
        int ValX=Random.Range(-20,0);
        //se instancia la creacion del animal y enseguida se mueve 
        Instantiate(arrAnimal[aleatorio],
                new Vector3(arrAnimal[aleatorio].transform.position.x,
                0,11),
                arrAnimal[aleatorio].transform.rotation);
    }
}
