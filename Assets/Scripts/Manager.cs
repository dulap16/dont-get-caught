using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Manager : MonoBehaviour
{
    [SerializeField] private Kissers kissers;
    [SerializeField] private Seer seer;
    [SerializeField] private GameObject kissingBar;

    [SerializeField] private float ratio = 0.1f;
    [SerializeField] private float currentProgress;
    [SerializeField] private float finish = 100;

    // Update is called once per frame
    void Update()
    {
        if(kissers.getAreKissing())
        {
            if (seer.isSeeing())
                Debug.Log("You were caught");
            else
            {
                currentProgress = currentProgress + ratio;
                if (currentProgress >= finish)
                {
                    Debug.Log("finished");
                }
            }
        }
    }

    public float getPercentageDone()
    {
        if (currentProgress == 0)
            return 0;
        return finish / currentProgress;
    }
}
