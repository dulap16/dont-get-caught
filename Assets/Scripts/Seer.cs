using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seer : MonoBehaviour
{
    
    [SerializeField] private int state = 0; // 0 - idle, 1 - warning, 2 - seeing

    [SerializeField] private Manager manager;
    private SpriteRenderer sr;

    [SerializeField] private float timeBetweenSees = 5;

    [SerializeField] private float initialWarningTime;
    private float nextWarningTime;

    public float seeingTime = 2;
    [SerializeField] private AnimationCurve _curve;

    IEnumerator WaitUntilWarning(float seconds)
    {
        
        yield return new WaitForSeconds(seconds);

        nextWarningTime = calculateNextWarningTime();
        StartWarning();
    }

    IEnumerator WaitUntilStartSeeing(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        StartSeeing();
    }

    IEnumerator WaitUntilStopSeeing(float seconds)
    {
        yield return new WaitForSeconds(seconds);

        StopSeeing();
    }

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        nextWarningTime = initialWarningTime;

        StopSeeing();
    }

    private void StartWarning()
    {
        state = 1;
        sr.color = new Color(255, 255, 0);

        StartCoroutine(WaitUntilStartSeeing(nextWarningTime));
    }

    private void StartSeeing()
    {
        state = 2;
        sr.color = new Color(255, 0, 0);

        StartCoroutine(WaitUntilStopSeeing(seeingTime));
    }

    private void StopSeeing()
    {
        state = 0;
        sr.color = new Color(0, 255, 0);

        StartCoroutine(WaitUntilWarning(timeBetweenSees));
    }

    private float calculateNextWarningTime()
    {
        Debug.Log(manager.getPercentageDone());
        return initialWarningTime * _curve.Evaluate(manager.getPercentageDone());
    }

    public bool isIdle()
    {
        return state == 0;
    }

    public bool isWarning()
    {
        return state == 1;
    }

    public bool isSeeing()
    {
        return state == 2;
    }
}
