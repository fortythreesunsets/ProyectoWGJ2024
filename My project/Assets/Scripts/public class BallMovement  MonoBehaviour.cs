using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyBall : MonoBehaviour
{
    //movement direction
    public Vector3 direction = Vector3.zero;

    // Update is called once per frame
    void Update()
    {
        //movement update
        transform.position += direction * Time.deltaTime;
    }
}
