using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CivirCarSpawn : MonoBehaviour
{
    public float carSpawnDelay = 2f;
    public GameObject civilCar;

    private float[] lanesArray;

    private float spawnDelay;

    void Start()
    {
        lanesArray = new float[4];
        lanesArray[0] = -3.31f;
        lanesArray[1] = -1.18f;
        lanesArray[2] = 1.18f;
        lanesArray[3] = 3.31f;
        spawnDelay = carSpawnDelay;
    }

    void Update()
    {
        spawnDelay -= Time.deltaTime;
        if (spawnDelay <= 0)
        {
            spawnCar();
            spawnDelay = carSpawnDelay;
        }
    }

    void spawnCar()
    {
        int lane = Random.Range(0, 4);
        if (lane == 0 || lane == 1)
        {
            GameObject car = (GameObject)Instantiate(civilCar, new Vector3(lanesArray[lane], 6f, 0), Quaternion.Euler(new Vector3(0, 0, 180)));
            car.GetComponent<CivilCarBehavior>().direction = 1;
            car.GetComponent<CivilCarBehavior>().civilCarSpeed = 12f;
        }
        if (lane == 2 || lane == 3)
        {
            Instantiate(civilCar, new Vector3(lanesArray[lane], 6f, 0), Quaternion.identity);
        }
    }
}