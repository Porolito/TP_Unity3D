using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using Object = UnityEngine.Object;

public class ZombieCollider : MonoBehaviour
{
    public Transform GFX;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("PlayerObj"))
        {
            Debug.Log("caca");
            other.gameObject.GetComponent<PlayerEndCondition>().Die();
        }
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
        }
    }

    public void InitModel(GameObject model)
    {
        Instantiate(model, GFX);
    }
}
