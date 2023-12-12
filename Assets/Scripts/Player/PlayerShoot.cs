using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public Transform firePos;
    public Transform orientation;
    public GameObject bullet;
    public Animator animator;
    public float shootCooldown;

    public KeyCode fireKey = KeyCode.Mouse0;
    
    [Header("Weapon Specs")]
    public int maxBullets;
    public int remainingBullets;
    public float reloadTime;

    private bool readyToShoot = true;
    public AudioSource audioSource;
    public AudioClip audioClip;

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
        animator.SetTrigger("Shoot");
        Instantiate(bullet, firePos.position, orientation.rotation);
        audioSource.PlayOneShot(audioClip);
        readyToShoot = false;
    }

    private void ResetShoot()
    {
        readyToShoot = true;
    }
}
