using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCounter : MonoBehaviour
{
    private static int platformCounter = 0;

    public static int Count
    {
        get { return platformCounter;}
        set 
        {
            counterUpdate?.Invoke(value);
            platformCounter = value; 
        }
    }

    public static Action<int> counterUpdate;

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
        PlatformCounter.Count++;
    }

    private void OnDisable()
    {
        PlatformCounter.Count--;
    }
}
