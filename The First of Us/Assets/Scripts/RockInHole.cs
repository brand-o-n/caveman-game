using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RockInHole : MonoBehaviour
{
    GameObject rock;
    GameObject hole;
    GameObject filledhole;
    //private SpriteRenderer sprite;

    void Start () {
        //sprite = GetComponent<SpriteRenderer>();
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
            //filledhole = GameObject.FindWithTag ("FilledHole");
            //filledhole.sortingOrder = 4;
            filledhole.SetActive (true);

        }
    }

}
