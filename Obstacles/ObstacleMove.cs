using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMove : MonoBehaviour
{
    [SerializeField] private AudioSource _electroFX;
    [SerializeField] private float _speed;


    private void Start()
    {
        _electroFX = GetComponent<AudioSource>();
    }
    private void Update()
    {
        transform.position -= transform.right * _speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
     
         if(collision.gameObject.tag == "Player")
        {
            _electroFX.Play();
        
        }else if (collision.gameObject.tag == "Wall")
        {
            Destroy();
        }
    }

    private void Destroy()
    {
        Destroy(gameObject);
    }
}
