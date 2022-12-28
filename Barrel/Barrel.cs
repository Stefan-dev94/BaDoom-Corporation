using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barrel : MonoBehaviour
{
    [SerializeField] private float _health = 2f;
    [SerializeField] private float _forceInpulse = 25f;
    [SerializeField] private GameObject _firstExplode;
    [SerializeField] private GameObject _bigExplode;
    [SerializeField] private Transform _explodePoint;
    private CamShake _shake;

    private BoxCollider2D _collider;
    private Rigidbody2D _rb;

    private void Start()
    {
        _shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<CamShake>();
        _rb = GetComponent<Rigidbody2D>();
        _collider = GetComponent<BoxCollider2D>();
        _rb.gravityScale = 0f;
        Destroy(gameObject, 10f);
    }
    public void ApplyDamage(float damage)
    {
        _health -= damage;

        if (_health == 0)
        {
            StartCoroutine(Die());
        }
    }
    private IEnumerator Die()
    {
        Instantiate(_firstExplode, _explodePoint.position, transform.rotation * Quaternion.Euler(0, 0, 180f));
        _rb.gravityScale = 1f;
        _collider.enabled = false;
        _rb.AddForce(Vector2.up * _forceInpulse, ForceMode2D.Impulse);
        yield return new WaitForSeconds(0.6f);
        Instantiate(_bigExplode, transform.position, Quaternion.identity);
        _shake.Shake();
        Destroy(gameObject);
    }
}
