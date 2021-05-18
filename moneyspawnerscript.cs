using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moneyspawnerscript : MonoBehaviour
{
    public GameObject spawningobject;
    float randx;
    public float spawnRate;
    Vector2 whereToSpawn;
    float nextSpawn;
    public float spawnTime;
    public float spawnDelay;
    private static int numberOfObjectsSpawned;
    bool status;
    // Start is called before the first frame update
    void Start()
    {
        numberOfObjectsSpawned = 0;
        status = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (numberOfObjectsSpawned >= 10)
        {
            CancelInvoke("SpawnObject");
            numberOfObjectsSpawned = 0;
            status = false;
        }
        if (TimerObject.currentTime < 1)
        {
            status = true;
        }
        if (status)
        {
            InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        }
        
    }

    public void SpawnObject()
    {
        GameObject money = Instantiate(spawningobject, transform.position, transform.rotation) as GameObject;
        money.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
        ++numberOfObjectsSpawned;
    }
}
