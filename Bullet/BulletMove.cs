using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMove : MonoBehaviour
{
    [SerializeField] private GameObject _bulletDestroy;
    [SerializeField] private float _speed;
    [SerializeField] private float _damage =1f;

    private void Update()
    {
        transform.position += transform.right * _speed * Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.TryGetComponent(out AlienHealth alien))
        {
            alien.ApplyDamage(_damage);
            Instantiate(_bulletDestroy, transform.position, Quaternion.identity);
            Destroy();
        }
        else if(collision.TryGetComponent(out Barrel barrel))
        {
            barrel.ApplyDamage(_damage);
            Instantiate(_bulletDestroy, transform.position, Quaternion.identity);
            Destroy();
        }
        else if(collision.gameObject.tag == "Wall")
        {
            Destroy();
        }
    }

    private void Destroy()
    {
        gameObject.SetActive(false);
    }
}
