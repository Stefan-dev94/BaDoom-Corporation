using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MineSkull : MonoBehaviour
{
    [SerializeField] private GameObject _brokeHelmet;
    [SerializeField] private Transform[] _spawnPoint;
    [SerializeField] private float _speed = 2f;

    private GameObject _target;

    private void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if(collision.gameObject.tag == "Player")
        {
            int random = Random.Range(0, _spawnPoint.Length);
            Instantiate(_brokeHelmet, _spawnPoint[random].position, Quaternion.identity);
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        if (_target != null)
        {
            transform.position = Vector2.MoveTowards(transform.position, _target.transform.position, _speed * Time.fixedDeltaTime);
        }
    }
}
