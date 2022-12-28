using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObstacles : MonoBehaviour
{
    [SerializeField] private GameObject[] _obstaclePrefab;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _waitSeconds;
    [SerializeField]private float _timeBtw = 50f;
    [SerializeField] private float _extremeTimeBtw = 100f;

    private float _currentTime;

    private void Start()
    {
        StartCoroutine(SpawnObjects());
    }

    IEnumerator SpawnObjects()
    {   
        while (true)
        {
            _currentTime += Time.deltaTime;
            int indexObstacle = Random.Range(0, _obstaclePrefab.Length);
            int indexPoints = Random.Range(0, _spawnPoints.Length);
            yield return new WaitForSeconds(_waitSeconds);
            Instantiate(_obstaclePrefab[indexObstacle], _spawnPoints[indexPoints].position, transform.rotation);
        }
    }
    private void Update()
    {

        _currentTime += Time.deltaTime;

        if(_currentTime >= _timeBtw)
        {
            _waitSeconds = 3f;
        }
         if (_currentTime >= _extremeTimeBtw)
        {
            _waitSeconds = 1.2f;
        }
    }
}
