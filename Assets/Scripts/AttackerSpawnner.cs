using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttackerSpawnner : MonoBehaviour
{
    [SerializeField] float minSpawnDelay = 1f;
    [SerializeField] float maxSpawnDelay = 5f;
    [SerializeField] Attacker attackerPrefab;
    [SerializeField] bool spawn = true;

    IEnumerator Start()
    {
        while(spawn)
        {
            yield return new WaitForSeconds(Random.Range(minSpawnDelay, maxSpawnDelay));
            SpawnEnemy();
        }
    }

    private void SpawnEnemy()
    {
        Instantiate(attackerPrefab, transform.position, transform.rotation);
    }
}
