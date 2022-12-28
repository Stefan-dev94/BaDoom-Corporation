using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketActivator : MonoBehaviour
{
    [SerializeField] private GameObject _missile;
    [SerializeField] private Transform _spawnPosition;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ActiveMissile")
        {
            Destroy(gameObject);
            Instantiate(_missile, _spawnPosition.position, Quaternion.identity);
        }
    }
}
