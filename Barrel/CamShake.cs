using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamShake : MonoBehaviour
{
    [SerializeField] private Animator _camShakeAnim;

    public void Shake()
    {
        _camShakeAnim.SetTrigger("Shake");
    }
}
