using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotRobot : MonoBehaviour
{
    [SerializeField] private GameObject _bullet;
    [SerializeField] private Transform _shotPoint;
    [SerializeField] private BoxCollider2D _boxCollider;
    [SerializeField] private float _waitingBtwShot = 5f; 
   
    private Animator _anim;

    private void Start()
    {
        _anim = GetComponent<Animator>();
        _boxCollider = GetComponent<BoxCollider2D>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {       
            StartCoroutine(Shot());
        }
    }
    private IEnumerator Shot()
    {
        _anim.SetBool("Shoot", true);
        Instantiate(_bullet, _shotPoint.position, Quaternion.identity);
        yield return new WaitForSeconds(0.3f);
        _anim.SetBool("Shoot", false);
        _boxCollider.enabled = false;
        yield return new WaitForSeconds(_waitingBtwShot);
        _boxCollider.enabled = true;
    }
}
