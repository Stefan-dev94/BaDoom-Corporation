using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerHealth : MonoBehaviour
{
    [SerializeField] private float _health=1;
    [SerializeField] private GameObject _jetPackFireDie;
    [SerializeField] private GameObject _explosion;
    [SerializeField] private GameObject _explosionDie;
    [SerializeField] private GameObject _losePanel;
    [SerializeField] private Transform _explosionPosition; 
    [SerializeField] private BoxCollider2D _collider;

    private Rigidbody2D _rb;
    private PlayerInput _player;
    private Animator _playerDie;

    private void Awake()
    {
        _rb = GetComponent<Rigidbody2D>();
        _player = GetComponent<PlayerInput>();
        _playerDie = GetComponent<Animator>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Obstacles")
        {
            _health-=1;
           
            if (_health <= 0)
            {
                _rb.freezeRotation = false;
                StartCoroutine(Died());
            }
        }
    }

    public void TakeDamage(float damage)
    {
        _health -= damage;

        if (_health <= 0)
        {         
            StartCoroutine(Died());            
        }
    }

    private IEnumerator Died()
    {
        _collider.enabled = false;
        _player.ForceMode(0);
        _playerDie.SetBool("isDie", true);
        Instantiate(_explosion, _explosionPosition.position, transform.rotation* Quaternion.Euler(0,0,90f));
        yield return new WaitForSeconds(0.3f);
        _jetPackFireDie.SetActive(true);
        _player.MoveRight();
        yield return new WaitForSeconds(1f);
        Instantiate(_explosionDie, _explosionPosition.position, transform.rotation);
        Destroy(gameObject);
        _losePanel.SetActive(true);
    }
}
