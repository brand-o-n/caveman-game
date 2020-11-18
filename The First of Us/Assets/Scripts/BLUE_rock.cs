using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BLUE_rock : MonoBehaviour
{
    GameObject brock;
    GameObject bhole;
    GameObject bfilledhole;

    void Start () {
        bfilledhole = GameObject.FindWithTag ("FilledHole_BLUE");
        bfilledhole.SetActive (false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("BLUE_rock"))
        {
            Debug.Log("Rock over hole");
            brock = GameObject.FindWithTag ("BLUE_rock");
            brock.SetActive (false);
            bhole = GameObject.FindWithTag ("EmptyHole_BLUE");
            bhole.SetActive (false);
            bfilledhole.SetActive (true);

        }
    }

}