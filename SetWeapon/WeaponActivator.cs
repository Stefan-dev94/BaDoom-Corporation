using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WeaponActivator : MonoBehaviour
{
    [SerializeField] private GameObject _gun;
    [SerializeField] private GameObject _shotGun;
    [SerializeField] private GameObject _machineGun;
    [SerializeField] private AudioSource _pickUpWeapon;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "ShotGun")
        {
            _machineGun.SetActive(false);
            _shotGun.SetActive(true);
            _gun.SetActive(false);
            Destroy(collision.gameObject);
            _pickUpWeapon.Play();
        }
        else if(collision.gameObject.tag == "Gun")
        {
            _machineGun.SetActive(false);
            _shotGun.SetActive(false);
            _gun.SetActive(true);
            Destroy(collision.gameObject);
            _pickUpWeapon.Play();
        }
        else if(collision.gameObject.tag == "MachineGun")
        {
            _machineGun.SetActive(true);
            _gun.SetActive(false);
            _shotGun.SetActive(false);
            Destroy(collision.gameObject);
            _pickUpWeapon.Play();
        }
    }
}
