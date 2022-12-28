using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyExplosion : MonoBehaviour
{
    [SerializeField] private float _destroyTime;
    void Update()
    {
        Destroy(gameObject, _destroyTime);
    }
}
