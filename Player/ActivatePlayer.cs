using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivatePlayer : MonoBehaviour
{
    [SerializeField] private GameObject _player;
    [SerializeField] private GameObject _steam;
    [SerializeField] private Transform _steamSpawnPoint;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ActivePlayer")
        {
            Instantiate(_steam, _steamSpawnPoint.position, Quaternion.identity);
            _player.SetActive(true);
            Destroy(collision.gameObject);
        }
    }
}
