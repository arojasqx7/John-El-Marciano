using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeleportScript : MonoBehaviour {

    public float minX;
    public float maxX;
    public float minY;
    public float maxY;

    void FixedUpdate()
    {
        float x = transform.position.x;
        float y = transform.position.y;

        if (x < minX) x = maxX;
        else if (x > maxX) x = minX;

        if (y < minY) y = maxY;
        else if (y > maxY) y = minY;

        transform.position = new Vector3(x, y, transform.position.z);
    }

}
