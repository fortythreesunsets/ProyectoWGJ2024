using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DrawCounterString : MonoBehaviour
{
    TMPro.TMP_Text counterText;

    // Start is called before the first frame update
    void Start()
    {
        counterText = GetComponent<TMPro.TMP_Text>();
        BallCounter.counter.counterUpdate += UpdateText;
        UpdateText(BallCounter.counter.numBalls);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateText(int i)
    {
        counterText.text = "x " + i.ToString();
    }
}
