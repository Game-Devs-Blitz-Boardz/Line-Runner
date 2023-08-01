using UnityEngine;
using System.Collections;

public class ObstacleSpawner : MonoBehaviour
{

    Vector3 spawnPos;
    public float spawnRate;
    public GameObject[] obstacles;

    void Start()
    {
        spawnPos = transform.position;

        StartCoroutine(SpawnObstacles());
    }

    void Update()
    {
        
    }

    void Spawn() {
        int spawnEl = Random.Range(0, obstacles.Length);

        Instantiate(obstacles[spawnEl], spawnPos, transform.rotation);
    }

    IEnumerator SpawnObstacles() {
        while (true) {
            Spawn();
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
