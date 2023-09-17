using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Seer : MonoBehaviour
{
    
    [SerializeField] private int state = 0; // 0 - idle, 1 - warning, 2 - seeing

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
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
