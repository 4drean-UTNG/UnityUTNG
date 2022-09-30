using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;

    private float startDelay = 1.0f;
    private float spawnInterval = 4.0f;

    // aqui se utiliza en la primera vez
    void Start()
    {
        SpawnRandomBall();
    }

    // este codigo es para generar pelotas random 
    void SpawnRandomBall ()
    {
        // Se genera en una pisision dinamica
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);

        // aqui se elige una bola random de las varias que existen
        int ballNumber = Random.Range(0, ballPrefabs.Length);
        Instantiate(ballPrefabs[ballNumber], spawnPos, ballPrefabs[ballNumber].transform.rotation);
        Invoke("SpawnRandomBall",Random.Range(2f,4f));
    }

}
