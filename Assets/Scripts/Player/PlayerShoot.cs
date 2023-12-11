using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform firePos;
    public Transform orientation;
    public GameObject bullet;
    public float shootCooldown;

    public KeyCode fireKey = KeyCode.Mouse0;
    
    [Header("Weapon Specs")]
    public int maxBullets;
    public int remainingBullets;
    public float reloadTime;

    private bool readyToShoot = true;

    private void Update()
    {
        if (Input.GetKey(fireKey) && readyToShoot)
        {
            Shoot();
            
            Invoke(nameof(ResetShoot), shootCooldown);
        }
    }

    private void Shoot()
    {
        Debug.Log("caca");
        Instantiate(bullet, firePos.position, orientation.rotation);
        readyToShoot = false;
    }

    private void ResetShoot()
    {
        readyToShoot = true;
    }
}
