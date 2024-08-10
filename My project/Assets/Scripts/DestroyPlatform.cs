using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPlatform : MonoBehaviour
{
    public static int waitToDestroy = 0;
    public float timeToDestroy = 3.0f;
    float timeCounter = 0f;

    bool isHit = false;
    int hitCounter = 0;
    SpriteRenderer spriteRenderer;
    Color defaultColor;
    /*
    bool isHIt = false;
    public float timeToColor;
    SpriteRenderer spriteRenderer;
    Color defaultColor;*/

    // Start is called before the first frame update
    void Start()
    {
        /*
        spriteRenderer = GetComponent<SpriteRenderer>();
        defaultColor = spriteRenderer.color;*/
    }
    /*
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (!isHIt)
        {
            isHIt = true;
            StartCoroutine("SwithColor");
        }
    }

    IEnumerator SwitchColor()
    {
        spriteRenderer.color = new Color(1f, 0.30196078f, 0.30196078f);
        yield return new WaitForSeconds(timeToColor);
        spriteRenderer.color = defaultColor;
        isHIt=false; 
    }*/
    
    // Update is called once per frame
    void Update()
    {
        if (this!= null)
        {
            if (isHit)
            {
                timeCounter += Time.deltaTime;
                if (timeCounter > waitToDestroy)
                    GameObject.Destroy(this.gameObject);
            }
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (!isHit && hitCounter <= 0)
        {
            isHit = true;
            this.GetComponent<SpriteRenderer>().color = Color.gray;
            OnBoardBallCount.counterUpdate += ballCounterUpdate;
            waitToDestroy++;
        }
        hitCounter++;
        Debug.Log("Change color to gray");

        if (isHit && hitCounter > 1)
        {
            isHit = true;
            this.GetComponent<SpriteRenderer>().color = Color.red;
            OnBoardBallCount.counterUpdate += ballCounterUpdate;
            waitToDestroy++;
            hitCounter++;
            Debug.Log("Change color to red");
        }
        
    }

    void ballCounterUpdate()
    {
        if (this != null)
        {
            GameObject.Destroy(this.gameObject);
        }
    }

    private void OnDisable()
    {
        OnBoardBallCount.counterUpdate -= ballCounterUpdate;
        waitToDestroy--;
    }
}
   