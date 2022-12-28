using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTank : MonoBehaviour
{
    [SerializeField] private GameObject _tank;
    [SerializeField] private Transform _spawnPoint;
    [SerializeField] private AudioSource _pickUpWeapon;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "TankActivator")
        {
            Instantiate(_tank, _spawnPoint.position, Quaternion.identity);
            Destroy(collision.gameObject);
            _pickUpWeapon.Play();
        }
    }
}
