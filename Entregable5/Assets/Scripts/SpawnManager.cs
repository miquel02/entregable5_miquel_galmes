using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    private Vector3 spawnPos = new Vector3(0, 0, 30);
    private float randomY;
    private float spawnStart = 0.5f;
    private float spawnFollow = 5f;
    private float spawnDistance = 50f;
    private float rangeDown = -10f;
    private float rangeUp = 10f;


    //Indicamos quando debe repetirse
    void Start()
    {
        InvokeRepeating("SpawnObstacle", spawnStart, spawnFollow);
    }

    //funcion paradeterminar la posicion dels spawn manager
    private void SpawnObstacle()
    {
        randomY = Random.Range(rangeDown, rangeUp);
        spawnPos = new Vector3(0, randomY, spawnPos.z + spawnDistance);
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
