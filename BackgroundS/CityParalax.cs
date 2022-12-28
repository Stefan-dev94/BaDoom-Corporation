using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityParalax : MonoBehaviour
{
    [SerializeField] private float _speedParalax;
    [SerializeField] private Renderer _cityRenderer;

    private void Update()
    {
        _cityRenderer.material.mainTextureOffset += new Vector2(_speedParalax * Time.deltaTime,0); 
    }
}
