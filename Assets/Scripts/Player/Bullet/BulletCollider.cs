using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollider : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.CompareTag("Terrain"))
            Destroy(this.gameObject);
        if(other.gameObject.CompareTag("Enemy"))
            Destroy(this.gameObject);
    }
}
