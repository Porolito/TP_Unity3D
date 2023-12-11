using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPickup : MonoBehaviour
{
    public Transform itemPos;
    public Transform orientation;
    public GameObject pickedObject;
    public KeyCode releaseButton = KeyCode.E;
    
    private bool isPicking = false;

    private void Update()
    {
        RotateObject();
        ReleaseItem();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.CompareTag("Pickable") && !isPicking)
        {
            isPicking = true; 
            other.transform.SetParent(itemPos, true);
            other.transform.position = itemPos.position;
            other.collider.enabled = false;
            other.rigidbody.useGravity = false;
            other.rigidbody.isKinematic = true;
            pickedObject = other.gameObject;
        }
            
    }

    private void ReleaseItem()
    {
        if (isPicking && Input.GetKey(releaseButton))
        {
            pickedObject.GetComponent<Collider>().enabled = true;
            pickedObject.GetComponent<Rigidbody>().useGravity = true;
            pickedObject.GetComponent<Rigidbody>().isKinematic = false;
            pickedObject.transform.SetParent(null);
            pickedObject.GetComponent<Rigidbody>().AddForce(itemPos.forward * 10f, ForceMode.Impulse);
            isPicking = false;
        }
    }

    private void RotateObject()
    {
        if (isPicking)
        {
            pickedObject.transform.rotation = orientation.rotation;
        }
    }
}
