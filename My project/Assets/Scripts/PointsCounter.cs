using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointsCounter
{
    public static PointsCounter counter = new PointsCounter();
    int points= 0;
    public Action<int> counterUpdate;

    public int numPoints
    {
        get { return points; }
        set
        {
            points = value;
            counterUpdate?.Invoke(numPoints);
        }
    }

    public void AddPoints()
    {
        points += 5;
        counterUpdate?.Invoke(numPoints);
    }

}
