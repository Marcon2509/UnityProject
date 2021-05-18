﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class monedeployer : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject asteroidPrefab;
    public float respawnTime = 0.25f;
    private Vector2 screenBounds;

    void Start()
    {
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        StartCoroutine(asteroidWave());
    }

 
    private void spawnEnemy()
    {
        GameObject a = Instantiate(asteroidPrefab) as GameObject;
        a.transform.position = new Vector2(Random.Range(screenBounds.x, -screenBounds.x), screenBounds.y * 2);
    }
    IEnumerator asteroidWave()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            spawnEnemy();
        }
    }
}
