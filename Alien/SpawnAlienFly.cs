using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnAlienFly : MonoBehaviour
{
    [SerializeField] private GameObject[] _alienFlylePrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private int _waitSeconds = 10;

    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {
        while (true)
        {
            yield return new WaitForSeconds(_waitSeconds);
            int indexObstacle = Random.Range(0, _alienFlylePrefab.Length);
            int indexPoints = Random.Range(0, _spawnPoints.Length);
            Instantiate(_alienFlylePrefab[indexObstacle], _spawnPoints[indexPoints].position, transform.rotation);
        }
    }
}
