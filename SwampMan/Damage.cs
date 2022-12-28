using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damage : MonoBehaviour
{
    [SerializeField] private GameObject _cleanWindow;
    [SerializeField] private GameObject _greenExplosion;
    [SerializeField] private Transform _spawnPoint;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            Instantiate(_cleanWindow, _spawnPoint.position, Quaternion.identity);
            Instantiate(_greenExplosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
