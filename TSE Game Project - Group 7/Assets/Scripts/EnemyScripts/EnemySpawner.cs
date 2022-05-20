using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField]
    // variables:
    private float spawnRadius = 7f;
    [SerializeField]
    private float time = 1.5f;

    public GameObject[] enemies;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnEnemy());
    }

    IEnumerator spawnEnemy()
    {
        Vector2 spawnPosition = GameObject.Find("Player").transform.position;
        spawnPosition = Random.insideUnitCircle.normalized * spawnRadius;

        Instantiate(enemies[Random.Range(0, enemies.Length)], spawnPosition, Quaternion.identity);

        yield return new WaitForSeconds(time);

        StartCoroutine(spawnEnemy());
    }
}
