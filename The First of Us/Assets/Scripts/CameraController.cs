using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Transform target;
    public Vector2 minPosition;
    public Vector2 maxPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(target.transform.position.x, minPosition.x, maxPosition.x), Mathf.Clamp(target.transform.position.y, minPosition.y, maxPosition.y), transform.position.z);
    }
}
