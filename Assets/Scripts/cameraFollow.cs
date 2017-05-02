using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{

    public Transform target;
    public float smoothing;

    Vector3 offset;
    public float lowY;

    void Start()
    {

        offset = transform.position = target.position;
        lowY = transform.position.y;

    }
    
    void Update()
    {
        Vector3 targetCanPos = target.position + offset;
        transform.position = Vector3.Lerp(transform.position, targetCanPos, -10f);

       // if (transform.position.y < lowY) transform.position = new Vector3(transform.position.x, lowY, transform.position.z);

    }
}
