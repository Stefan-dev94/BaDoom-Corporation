using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantiateSwamp : SkullIronHealth
{
    [SerializeField] private GameObject _swampMan;
    public override IEnumerator Die()
    {
        yield return new WaitForSeconds(0);
        Instantiate(_swampMan, transform.position, Quaternion.identity);
    }
}
