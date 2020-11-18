using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockInHole : MonoBehaviour
{
    GameObject rock;
    GameObject hole;
    GameObject filledhole;

    void Start () {
        filledhole = GameObject.FindWithTag ("FilledHole");
        filledhole.SetActive (false);
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("Rocky"))
        {
            Debug.Log("Rock over hole");
            rock = GameObject.FindWithTag ("Rocky");
            rock.SetActive (false);
            hole = GameObject.FindWithTag ("EmptyHole");
            hole.SetActive (false);
            filledhole.SetActive (true);

        }
    }

}
