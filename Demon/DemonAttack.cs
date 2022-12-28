using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DemonAttack : MonoBehaviour
{
    [SerializeField] private GameObject _bomb;

    private Animator _anim;

    private void Start()
    {
        _anim = GetComponent<Animator>(); 
    }
    public void Attack()
    {      
         Instantiate(_bomb, transform.position, Quaternion.identity);   
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Attack")
        {
            _anim.SetBool("Attack", true);
            Attack();
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        _anim.SetBool("Attack", false);
    }
}
