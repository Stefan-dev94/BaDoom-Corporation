using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionShake : MonoBehaviour
{
    private CamShake _shake;

    private void Start()
    {
        _shake = GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<CamShake>();
        _shake.Shake();
    }
}
