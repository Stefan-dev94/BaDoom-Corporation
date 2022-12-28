 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesSpawnerPool : PoolObjects
{
    [SerializeField] private GameObject _obstacles;
    [SerializeField] private Transform[] _spawnPoints;
    [SerializeField] private float _secondBetweenSpawn;

    private float _elepsedTime = 0f;

    private void Start()
    {       
            Initialize(_obstacles);     
    }

    private void Update()
    {
        _elepsedTime += Time.deltaTime;
       int index = Random.Range(0, _spawnPoints.Length);
        
          if (_elepsedTime >= _secondBetweenSpawn)
          {
              if (TryGetObject(out GameObject obstacles))
              {
                  _elepsedTime = 0;

                  SetBullet(obstacles, _spawnPoints[index].position);
              }
          }      
    }

    private void SetBullet(GameObject bullet, Vector3 spawnPoint)
    {
        bullet.SetActive(true);
        bullet.transform.position = spawnPoint;
    }
}
