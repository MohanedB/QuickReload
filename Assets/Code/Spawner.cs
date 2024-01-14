using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField]
    private GameObject powerUpPrefab;

    private void Start()
    {
        StartCoroutine(SpawnPowerUp());
    }

    private IEnumerator SpawnPowerUp()
    {
        while (true)
        {
            Vector3 spawnPosition = new Vector3(Random.Range(-10f, 10f), 0.9f, 0f);
            Instantiate(powerUpPrefab, spawnPosition, Quaternion.identity);

            yield return new WaitUntil(() => GameObject.FindGameObjectWithTag("PowerUp") == null);

            yield return new WaitForSeconds(10);
        }
    }
}