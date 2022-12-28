using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienWalkLeft : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position -= transform.right * _speed * Time.deltaTime;
    }

    public void MoveSpeed(float speed)
    {
        _speed = speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
