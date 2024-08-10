using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMouseMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //mouse position
        Vector3 worldPositionMouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        //mouse position relative to the object
        Vector3 relativePositionMouse = worldPositionMouse - transform.position;

        //object rotation
        float rotation_z = Mathf.Atan2(relativePositionMouse.y, relativePositionMouse.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.Euler(0f, 0f, rotation_z + 90);
    }
}
