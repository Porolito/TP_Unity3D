using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerBlink : MonoBehaviour
{
    public float distanceBlink;
    public KeyCode blinkKey = KeyCode.Mouse1;
    public float blinkCooldown = 3f;
    public LayerMask whatIsGround;
    public Transform forward;
    public GameObject crossairBlink;

    private bool isWall = false;
    private bool readyToBlink = true;
    
    private void Update()
    {
        isWall = Physics.Raycast(transform.position, transform.forward, distanceBlink + 1f, whatIsGround);

        if (Input.GetKey(blinkKey) && readyToBlink)
        {
            Blink();
            
            Invoke(nameof(ResetBlink), blinkCooldown);
        }
    }

    private void Blink()
    {
        if (!isWall && readyToBlink)
        {
            crossairBlink.SetActive(false);
            transform.position += forward.forward * distanceBlink;
            readyToBlink = false;
        }
    }

    private void ResetBlink()
    {
        crossairBlink.SetActive(true);
        readyToBlink = true;
    }
}
