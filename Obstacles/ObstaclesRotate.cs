using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclesRotate : MonoBehaviour
{
    [SerializeField] private Vector3 _rotateSpeed;

    private void Update()
    {
        transform.Rotate(_rotateSpeed * Time.deltaTime);
    }
}
