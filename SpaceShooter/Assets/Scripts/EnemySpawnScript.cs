using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawnScript : MonoBehaviour
{
    public GameObject Enemy;
    public int spawnCooldown;
    public int minCooldown;
    public int maxCooldown;
    public int timerStart;
    public bool timerStop;

    // Spawns enemies at random times in random positions.

    void Start()
    {
        StartCoroutine(SpawnEnemyAfterTime());
    }

    void Update()
    {
        spawnCooldown = Random.Range(minCooldown, maxCooldown);
    }

    IEnumerator SpawnEnemyAfterTime()
    {
        while (!timerStop)
        {
            yield return new WaitForSeconds(timerStart);
            Vector3 spawnPosition = new Vector3(Random.Range(-4f, 4f), Random.Range(0f, 2f), 0);
            Instantiate(Enemy, spawnPosition + transform.TransformPoint(0, 0, 25), gameObject.transform.rotation);
            yield return new WaitForSeconds(spawnCooldown);
        }
    }
}