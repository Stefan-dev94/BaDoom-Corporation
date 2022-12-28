using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienHealth : MonoBehaviour
{
    [SerializeField] private GameObject _bloodExplode;
    [SerializeField] private Transform _bloodPoint;
    [SerializeField] protected float _health =2f;

   public virtual IEnumerator Die()
    {   
        Instantiate(_bloodExplode, transform.position, Quaternion.Euler(0,0,-90));
        yield return new WaitForSeconds(0f);
        Destroy(gameObject);
    }

    public virtual void ApplyDamage(float damage)
    {
        _health -= damage;

        if (_health <= 0)
        {
            StartCoroutine(Die());
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            Destroy(gameObject);
        }
    }
}
