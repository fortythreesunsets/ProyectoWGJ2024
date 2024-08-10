using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnBoardBallCount : MonoBehaviour
{
    private static int counter = 0;

    public static int Count
    {
        get { return counter; }
        set
        {
            if (value <= 0) counterUpdate?.Invoke();
            counter = value;
        }
    }

    public static Action counterUpdate;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnEnable()
    {
        OnBoardBallCount.Count++;
    }

    private void OnDisable()
    {
        OnBoardBallCount.Count--;
    }
}
