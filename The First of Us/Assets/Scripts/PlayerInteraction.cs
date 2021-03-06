﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteraction : MonoBehaviour
{
    public GameObject currentInterObj = null;

    void Update() 
    {
        if(Input.GetButtonDown ("Interact") && currentInterObj) 
        {
            currentInterObj.SendMessage ("DoInteraction");
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag ("interObject")) {
            Debug.Log (other.name);
            currentInterObj = other.gameObject;
        }
    }

    void OnTriggerExit2D(Collider2D other) 
    {
        if (other.CompareTag ("interObject")) {
            if(other.gameObject == currentInterObj) 
            {
                currentInterObj = null;
            }
        }
    }


}
