using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZombieCollider : MonoBehaviour
{
    private GameObject camObj;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("PlayerObj"))
        {
            Debug.Log("caca");
            Destroy(other.gameObject);
            camObj = GameObject.Find("CameraHolder");
            camObj.SetActive(false);
        }

        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
        }
    }
}
