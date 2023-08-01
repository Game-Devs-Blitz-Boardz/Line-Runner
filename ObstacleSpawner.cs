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
        int spawnSide = Random.Range(0, 2);

        spawnPos = transform.position;

        if (spawnSide < 1) {
            Instantiate(obstacles[spawnEl], spawnPos, transform.rotation);
        } else {
            // spawnPos = new Vector3(transform.position.x, -transform.position.y, 180);
            spawnPos.y = -transform.position.y;
            int xAdd = spawnEl;
            spawnPos.x += xAdd;

            GameObject obs = Instantiate(obstacles[spawnEl], spawnPos, transform.rotation);
            obs.transform.eulerAngles = new Vector3(0, 0, 180);
        }


        
    }

    IEnumerator SpawnObstacles() {
        while (true) {
            Spawn();
            GameManager.instance.UpdateScore();
            yield return new WaitForSeconds(spawnRate);
        }
    }
}
