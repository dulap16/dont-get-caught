using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Kissers : MonoBehaviour
{
    [SerializeField] private bool areKissing = false;
    private SpriteRenderer sr;
    private Color initColor;
    [SerializeField] private Color kissingColor;

    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        initColor = sr.color;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            areKissing = true;

        }
        else areKissing = false;
    }

    private void setColor(Color c)
    {
        sr.color = c;
    }

    private void kissing()
    {
        areKissing = true;
        setColor(kissingColor);
    }

    private void stoppedKissing()
    {
        areKissing = false;
        setColor(initColor);
    }

    public bool getAreKissing()
    {
        return areKissing;
    }
}
