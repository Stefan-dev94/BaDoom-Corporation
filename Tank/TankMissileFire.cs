using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankMissileFire : MonoBehaviour
{
    [SerializeField] private GameObject _projectile;
    [SerializeField] private GameObject _shootFire;
    [SerializeField] private GameObject _downShootFire;
    [SerializeField] private Transform _downShootPosition;
    [SerializeField] private Transform[] _position;
   

    private int _count = 6;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "MissileLaunch")
        {
            StartCoroutine(Shoot());
        }
    }

    IEnumerator Shoot()
    {    
        for (int i = 0; i < _count; i++)
        {
            int randomIndex = Random.Range(0, _position.Length);
            Instantiate(_downShootFire, _downShootPosition.position, Quaternion.Euler(0, 0, 39.2f));
            Instantiate(_shootFire, _position[randomIndex].position, Quaternion.Euler(0, 0, -140.8f));
            Instantiate(_projectile, _position[randomIndex].position, Quaternion.Euler(0, 0, -140.8f));        
            yield return new WaitForSeconds(0.4f);          
        }      
    }
}
