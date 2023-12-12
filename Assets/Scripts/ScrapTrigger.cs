using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrapTrigger : MonoBehaviour
{
    public GameObject player;
    public int scrapCollected = 0;

    // Update is called once per frame
    void Update()
    {
        if (scrapCollected == 5)
        {
            player.GetComponent<PlayerEndCondition>().Win();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("caca");
        if (other.CompareTag("Pickable"))
        {
            scrapCollected++;
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Pickable"))
        {
            scrapCollected--;
        }
    }
}
