using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DrawCounterString : MonoBehaviour
{
    TMPro.TMP_Text ballCounterText;

    // Start is called before the first frame update
    void Start()
    {
        ballCounterText = GetComponent<TMPro.TMP_Text>();
        BallCounter.counter.counterUpdate += UpdateText;
        UpdateText(BallCounter.counter.numBalls);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void UpdateText(int i)
    {
        ballCounterText.text = "Tiros disponibles: " + i.ToString();
    }
}
