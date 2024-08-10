using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCounter
{
    public static BallCounter counter = new BallCounter();
    int balls = 5;
    public Action<int> counterUpdate;

   public int numBalls
   { 
        get { return balls; }   
        set
        {
            balls = value;
            counterUpdate?.Invoke(numBalls);
        }
    }

    public void AddBall()
    {
        balls++;
        counterUpdate?.Invoke(numBalls);
    }

    public void RemoveBall()
    {
        balls--;
        counterUpdate?.Invoke(numBalls);
    }
}
