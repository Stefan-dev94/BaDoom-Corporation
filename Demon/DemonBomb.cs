using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonBomb : MonoBehaviour
{
    [SerializeField] private GameObject _fireGround;
    [SerializeField] private float _force;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();  
        _rb.AddForce(Vector2.left * _force, ForceMode2D.Impulse);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Ground")
        {
            Instantiate(_fireGround, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
}
