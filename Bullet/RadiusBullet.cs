using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RadiusBullet : MonoBehaviour
{
    public Vector2 direction = new Vector2(1, 0);
   
    [SerializeField] private float _speed = 2f;

    [SerializeField] private Vector2 _velocity;

    private void Start()
    {
        Destroy(gameObject, 2f);
    }

    private void Update()
    {
        _velocity = direction * _speed;
    }

    private void FixedUpdate()
    {
        Vector2 pos = transform.position;

        pos += _velocity * Time.deltaTime;

        transform.position = pos;
    }
}
