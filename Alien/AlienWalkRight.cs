using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlienWalkRight : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position += transform.right * _speed * Time.deltaTime;
    }
}
