using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject Bee;
    float maxSpawn = 5f;
    // Start is called before the first frame upda5te
    void Start()
    {
        Invoke("SpawnEnemy", maxSpawn);
        InvokeRepeating("IncreaseSpawn", 0f, 40f);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void SpawnEnemy()
    {
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        GameObject anEnemy = (GameObject)Instantiate(Bee);
        anEnemy.transform.position = new Vector2(max.x,Random.Range(min.y,max.y));
        NextEnemySpawn();
    }
    void NextEnemySpawn()
    {
        float SpawnInSecond;
        if (maxSpawn > 1f)
        {
            SpawnInSecond = Random.Range(1f, maxSpawn);
        }
        else
        {
            SpawnInSecond = 1f;
        }
        Invoke("SpawnEnemy", SpawnInSecond);
    }

    void IncreaseSpawn()
    {
        if (maxSpawn > 1f)
            maxSpawn--;
        if (maxSpawn == 1f)
            CancelInvoke("IncreaseSpawn");
    }
}
