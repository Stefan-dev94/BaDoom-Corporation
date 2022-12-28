using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrontWeapon : MonoBehaviour
{
    [SerializeField] private GameObject _bulletTemplate;
    [SerializeField] private GameObject _shootFire;
    [SerializeField] private Transform _spawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "TankTarget")
        {
            Instantiate(_shootFire, _spawnPoint.position, Quaternion.Euler(0, 0, -90));
            Instantiate(_bulletTemplate, _spawnPoint.position, Quaternion.identity);
        }
    }
}
