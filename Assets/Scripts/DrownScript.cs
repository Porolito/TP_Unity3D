using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrownScript : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PlayerObj"))
        {
            other.gameObject.GetComponent<PlayerEndCondition>().Die();
        }
        if (other.gameObject.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
        }
    }
}
