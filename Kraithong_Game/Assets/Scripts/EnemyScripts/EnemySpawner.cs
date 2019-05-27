using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float min_y = -4.3f, max_y = 4.3f;

    public GameObject[] obst_prefabs;

    public float timer = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("SpawnEnemies", timer);
    }

    void SpawnEnemies()
    {
        float pos_y = Random.Range(min_y, max_y);
        Vector3 temp = transform.position;
        temp.y = pos_y;

        if(Random.Range(0,2) > 0)
        {
            Instantiate(obst_prefabs[Random.Range(0, obst_prefabs.Length)],
            temp, Quaternion.identity);
        }

        Invoke("SpawnEnemies", timer);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
