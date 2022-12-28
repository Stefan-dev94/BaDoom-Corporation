using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponRadius : MonoBehaviour
{    
    [SerializeField] private Transform _shotPos;
    [SerializeField] private GameObject _bullet;
    [SerializeField] private GameObject _shotFire;
    [SerializeField] private int _amountOfBullets;
    [SerializeField] private float _spread;
    [SerializeField] private float _speed;
    [SerializeField] private float _secondBetweenSpawn;

    private float _elepsedTime = 0f;
    private bool _isActive;

    private void Update()
    {
        _elepsedTime += Time.deltaTime;

        if (_isActive || Input.GetKey(KeyCode.RightControl))
        {
            if (_elepsedTime >= _secondBetweenSpawn)
            {                               
                _elepsedTime = 0;
                Instantiate(_shotFire, _shotPos.position, Quaternion.identity);
                Shoot();                
            }
        }
    }

    public void Shoot()
    {
        for (int i = 0; i < _amountOfBullets; i++)
        {
            GameObject b = Instantiate(_bullet, _shotPos.position, _shotPos.rotation);
            Rigidbody2D brb = b.GetComponent<Rigidbody2D>();
            Vector2 dir = transform.rotation * Vector2.right;
            Vector2 pdir = Vector2.Perpendicular(dir) * Random.Range(-_spread, _spread);
            brb.velocity = (dir + pdir) * _speed;
        }
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
