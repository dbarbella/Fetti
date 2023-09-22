using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorPicker : MonoBehaviour
{
    public string colorMode = "Autumn";
    private int randomChoice;
    private List<Color> transRights = new List<Color>
                                    {new Color((91f / 255f), (206f / 255f), (250f / 255f), 1),
                                     new Color((245f / 255f), (169f / 255f), (184f / 255f), 1),
                                     Color.white};

    void Awake()
    {
        if (colorMode == "RandomBright")
        {
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.8f, 1f);
        }
        else if (colorMode == "Autumn")
        {
            GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 0.3f, 1f, 1f, 0.5f, 1f);
        }
        else if (colorMode == "TransRights")
        {
            randomChoice = Random.Range(0, 3);
            GetComponent<Renderer>().material.color = transRights[randomChoice];
        }
    }
}
