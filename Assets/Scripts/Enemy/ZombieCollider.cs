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
    public GameObject gameOverPanel;

    public Transform GFX;
    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("PlayerObj"))
        {
            Debug.Log("caca");
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
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
