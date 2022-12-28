using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RocketAction : MonoBehaviour
{
    [SerializeField] private GameObject _explosion;
    [SerializeField] private GameObject _flame;
    [SerializeField] private float _force;

    [SerializeField]private CapsuleCollider2D _collider;
    private Rigidbody2D _rb;

    private void Start()
    {
        _rb = GetComponent<Rigidbody2D>();       
        _flame.SetActive(false);
        StartCoroutine(ActiveRocket());
    }

    IEnumerator ActiveRocket()
    {
        yield return new WaitForSeconds(0.8f);
        _rb.gravityScale = 0f;
        _rb.velocity = new Vector2(-1f * _force, 0f);
        _flame.SetActive(true);        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent( out PlayerHealth player))
        {
            Instantiate(_explosion, transform.position, Quaternion.identity);
            _collider.enabled = false;
            player.TakeDamage(1f);
            Destroy(gameObject);
        }
        else if (collision.gameObject.tag == "Tank")
        {
            Instantiate(_explosion, transform.position, Quaternion.identity);
            Destroy(gameObject);
        }

        else if(collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
