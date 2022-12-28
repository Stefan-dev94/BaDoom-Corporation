using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienDamage : MonoBehaviour
{
    [SerializeField] private float _damage = 1f;
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.TryGetComponent(out PlayerHealth player))
        {
            player.TakeDamage(_damage);         
        }
    }
}
