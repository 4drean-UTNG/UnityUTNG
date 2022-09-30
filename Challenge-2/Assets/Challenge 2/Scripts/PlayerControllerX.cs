using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float cooldown =0;
    // se actualiza por frame
    void Update()
    {
        // Ocada que presionamos aparece un perro 
        //sin generar spam 
        if (Input.GetKeyDown(KeyCode.Space) && cooldown <=0)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            cooldown=1;
        }
        if(cooldown>=0){
            cooldown-=Time.deltaTime;
        }
    }
}
