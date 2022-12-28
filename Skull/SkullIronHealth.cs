using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkullIronHealth : AlienHealth
{
    [SerializeField] private GameObject _explosion;
    [SerializeField] private GameObject _lastExplosion;
    [SerializeField] private Transform _lastExplosionPoints;
    [SerializeField] private Transform[] _explosionPoints;
    [SerializeField] private int _count = 6;

    private CapsuleCollider2D _collider;
    private Animator _anim;
   

    private void Start()
    {
        _collider = GetComponent<CapsuleCollider2D>();
        _anim = GetComponent<Animator>();
    }
    public override IEnumerator Die()
    {
     
        _anim.SetBool("isDie", true);
        _collider.enabled = false;

        for (int i = 0; i <_count ; i++)     
        {
            int indexPoints = Random.Range(0, _explosionPoints.Length);
            Instantiate(_explosion, _explosionPoints[indexPoints].position, Quaternion.identity);
            yield return new WaitForSeconds(0.2f);
        }
        Instantiate(_lastExplosion, _lastExplosionPoints.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
