using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionDamage : MonoBehaviour
{
    [SerializeField] private float _damage = 4f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out AlienHealth enemy))
        {
            enemy.ApplyDamage(_damage);
        }
    }
}
