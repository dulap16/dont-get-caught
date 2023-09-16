using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kissers : MonoBehaviour
{
    [SerializeField] private bool areKissing = false;
    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            areKissing = true;

        }
        else areKissing = false;
    }
    public bool getAreKissing()
    {
        return areKissing;
    }
}
