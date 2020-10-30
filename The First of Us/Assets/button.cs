using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    // Start is called before the first frame update
	public void ClickTest()
    {
        Debug.Log("clicked");
    }

    // Update is called once per frame
    	public void ClickTest2 (string text)
    {
     Debug.Log(text);   
    }
}
