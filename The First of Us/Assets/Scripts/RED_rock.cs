using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RED_rock : MonoBehaviour
{
    GameObject rrock;
    GameObject rhole;
    GameObject rfilledhole;

    void Start () {
        rfilledhole = GameObject.FindWithTag ("FilledHole_RED");
        rfilledhole.SetActive (false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("RED_rock"))
        {
            Debug.Log("Rock over hole");
            rrock = GameObject.FindWithTag ("RED_rock");
            rrock.SetActive (false);
            rhole = GameObject.FindWithTag ("EmptyHole_RED");
            rhole.SetActive (false);
            rfilledhole.SetActive (true);

        }
    }

}