using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GREEN_rock : MonoBehaviour
{
    GameObject grock;
    GameObject ghole;
    GameObject gfilledhole;

    void Start () {
        gfilledhole = GameObject.FindWithTag ("FilledHole_GREEN");
        gfilledhole.SetActive (false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("GREEN_rock"))
        {
            Debug.Log("Rock over hole");
            grock = GameObject.FindWithTag ("GREEN_rock");
            grock.SetActive (false);
            ghole = GameObject.FindWithTag ("EmptyHole_GREEN");
            ghole.SetActive (false);
            gfilledhole.SetActive (true);

        }
    }

}