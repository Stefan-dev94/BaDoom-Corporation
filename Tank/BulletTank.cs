using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletTank : MonoBehaviour
{
    [SerializeField] private float speed = 2f;

    private void Start()
    {
        Destroy(gameObject, 4f);
    }
    private void Update()
    {
        transform.position = transform.position + new Vector3(3.5f, 1f, 0) * speed * Time.deltaTime;
    }
}
