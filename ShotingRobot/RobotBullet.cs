using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RobotBullet : MonoBehaviour
{
    [SerializeField] private float speed = 2f;
    [SerializeField] private Transform _position;
    [SerializeField] private GameObject _brokenGlass;

    private void Start()
    {
        Destroy(gameObject, 4f);
    }
    private void Update()
    {
        transform.position = transform.position + new Vector3(-3.5f, 1f, 0)* speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.GetComponent<PlayerHealth>())
        {
            Instantiate(_brokenGlass, _position.position, Quaternion.identity);
        }
    }
}
