using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CalculateResult : MonoBehaviour
{

    public GameObject winUI;
    public GameObject loseUI;

    // Start is called before the first frame update
    void Start()
    {
        PlatformCounter.counterUpdate += platformCounterUpdate;
        OnBoardBallCount.counterUpdate += ballCounterUpdate;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void platformCounterUpdate(int platformCounter)
    {
        if (platformCounter == 0)
        {
            winUI.SetActive(true);
        }
    }

    void ballCounterUpdate()
    {
        if (winUI.activeSelf != true)
            if (BallCounter.counter.numBalls <= 0 && DestroyPlatform.waitToDestroy <= 0)
                loseUI.SetActive(true);
    }

    public void replay()
    {
        PlatformCounter.counterUpdate -= platformCounterUpdate;
        OnBoardBallCount.counterUpdate -= ballCounterUpdate;
        BallCounter.counter.numBalls = 5;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
