using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarSpawner : MonoBehaviour
{

    public GameObject car;
    public Transform[] spawnPoints;

	void Update()
    {
	    if (GameManager.nextTimeToSpawn <= Time.time)
	    {
	        SpawnCar();
	        GameManager.nextTimeToSpawn = Time.time + GameManager.spawnTime;
	    }	
    } 

    void SpawnCar()
    {

	    int randomIndex = Random.Range(0, spawnPoints.Length);
	    Transform spawnPoint = spawnPoints[randomIndex];
	
	
	    Instantiate(car, spawnPoint.position, spawnPoint.rotation);
    }

}
