using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    public string colorMode = "RandomBright";

    void Awake()
    {
        if (colorMode == "RandomBright")
        {
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.8f, 1f);
        }
    }
}
