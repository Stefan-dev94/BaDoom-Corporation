using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateProjectile : MonoBehaviour
{
    [SerializeField] private GameObject _projectile;
    [SerializeField] private GameObject _shootFire;
    [SerializeField] private Transform[] _position;
    [SerializeField] private BoxCollider2D _boxColliderEnable;
  
    private int _count = 35;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "TankFire")
        {
            _boxColliderEnable.enabled = false;
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {      
        _shootFire.SetActive(true);
       
        for (int i = 0; i < _count; i++)
        {         
            int randomIndex = Random.Range(0, _position.Length);
            Instantiate(_projectile, _position[randomIndex].position, Quaternion.Euler(0, 0, 36.13f));
            yield return new WaitForSeconds(0.08f);
        }

        _shootFire.SetActive(false);
        _boxColliderEnable.enabled = true;
    }
}
