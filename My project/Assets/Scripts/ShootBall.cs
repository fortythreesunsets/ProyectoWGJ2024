using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    //ball to shoot
    public GameObject ball;

    //ball spawn distance
    public float offset = 1.0f;

    //shoot timer
    public float fireRate = 1.0f;
    float lastFire = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        //set shoot timer to 1
        lastFire = fireRate;
    }

    // Update is called once per frame
    void Update()
    {
        //update shoot timer
        lastFire += Time.deltaTime;

        //verification of pressed mouse button and timer
        if (BallCounter.counter.numBalls > 0) 
        {
            if (Input.GetMouseButtonDown(0))
            {
                if (lastFire > fireRate)
                {
                    //reset timer
                    lastFire = lastFire % fireRate;

                    //create instance of ball
                    GameObject obj_ball = GameObject.Instantiate(ball);
                    obj_ball.transform.position = transform.position - transform.up * offset;

                    //remove a ball from the list
                    BallCounter.counter.RemoveBall();
                    obj_ball.GetComponent<Rigidbody2D>().AddForce(-transform.up * 9.81f, ForceMode2D.Impulse);

                    /*
                    //direction of ball
                    obj_ball.GetComponent<BallMovement>().direction = -transform.up;
                   */
                }
                
            }
        }
    }

 }
