using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private float _force = 25f;
    [SerializeField] private Transform _groundCheck;
    [SerializeField] private LayerMask _whatIsGround;
    [SerializeField] private float _checkRadius = 0.5f;
    [SerializeField] private AudioSource _step;
    [SerializeField] private GameObject _jetPackFire;

    private Animator _anim;
    private bool _isGrounded;  
    private Rigidbody2D _rigidbody;
    bool _isActive;
  
    private void Start()
    {
        _anim = GetComponent<Animator>();
        _step = GetComponent<AudioSource>();
        _rigidbody = GetComponent<Rigidbody2D>();     
        _isGrounded = Physics2D.OverlapCircle(_groundCheck.position, _checkRadius, _whatIsGround);
    }

    private void Update()
    {
        if (_isGrounded)
        {
            if (!_step.isPlaying)
                _step.Play();
            _anim.SetBool("isFly", false);
        }
        else
        {
            _anim.SetBool("isFly", true);
            _step.Stop();
        }
    } 
    private void FixedUpdate()
    {
        _isGrounded = Physics2D.OverlapCircle(_groundCheck.position, _checkRadius, _whatIsGround);
        Fly();
    }

    public void Fly()
    {

        if (_isActive || Input.GetKey(KeyCode.Space))
        {
            _rigidbody.AddForce(Vector2.up * _force, ForceMode2D.Impulse);
            _jetPackFire.SetActive(true);
        }
        else
        {
            _jetPackFire.SetActive(false);
        }
    }

    public void MoveRight()
    {
        _rigidbody.AddForce(Vector2.right *  200);
    }

    public void ForceMode(float force)
    {
        _force = force;
    }

    public void PointerDown()
    {
        _isActive = true;
    }

    public void PointerUp()
    {
        _isActive = false;
    }
}
