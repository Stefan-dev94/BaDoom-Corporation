using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpawner : PoolObjects
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _bulletFireShot;
    [SerializeField] private Transform _spawnPoints;
    [SerializeField] private float _secondBetweenSpawn;

    private float _elepsedTime = 0f;
    bool _isActive;

    private void Start()
    {
        Initialize(_bullet);
    }
    private void Update()
    {
        _elepsedTime += Time.deltaTime;
       
        if (_isActive || Input.GetKey(KeyCode.RightControl))
        {
            if (_elepsedTime >= _secondBetweenSpawn)
            {
                if (TryGetObject(out GameObject bullet))
                {
                    _elepsedTime = 0;
                    Instantiate(_bulletFireShot, _spawnPoints.position, Quaternion.identity);
                    SetBullet(bullet, _spawnPoints.position);
                }
            }
        }
    }

    private void SetBullet (GameObject bullet, Vector3 spawnPoint)
    {
        bullet.SetActive(true);
        bullet.transform.position = spawnPoint;
    }

    public void PointerDown()
    {
        _isActive = true;
    }

    public void PointerUp()
    {
        _isActive = false;
    }
}
