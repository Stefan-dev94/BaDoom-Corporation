using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossShot : MonoBehaviour
{
    [SerializeField] private GameObject _projectile;
    [SerializeField] private Transform _spawnPosition;
    [SerializeField] private GameObject _fireShot;
    [SerializeField] private float _secondBetweenSpawn = 2f;


    private float _elepsedTime = 0f;
    void Update()
    {
        _elepsedTime += Time.deltaTime;
    
        if (_elepsedTime >= _secondBetweenSpawn)
        {                
            _elepsedTime = 0;
            Instantiate(_fireShot,_spawnPosition.position,Quaternion.identity);
            Shot();
        }       
    }

    private void Shot()
    {
        Instantiate(_projectile, _spawnPosition.position, Quaternion.identity);
    }
}
