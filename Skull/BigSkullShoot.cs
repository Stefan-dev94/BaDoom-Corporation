using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigSkullShoot : MonoBehaviour
{
    [SerializeField] private GameObject _mineSkull;
    [SerializeField] private Transform[] _spawnPoint;
    [SerializeField] private float _secondBetweenSpawn;

    private CamShake _camShake;

    private float _elepsedTime = 0f;

    private void Start()
    {
        _camShake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<CamShake>(); 
    }

    private void Update()
    {
        _elepsedTime += Time.deltaTime;

        if (_elepsedTime >= _secondBetweenSpawn)
        {
            _elepsedTime = 0;
            int randomIndex = Random.Range(0, _spawnPoint.Length);
            Instantiate(_mineSkull, _spawnPoint[randomIndex].position, Quaternion.identity);
            _camShake.Shake();
        }
    }
  
}
