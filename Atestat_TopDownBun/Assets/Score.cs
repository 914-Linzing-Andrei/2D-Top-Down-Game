using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class Score : MonoBehaviour
{
    public static int scoreValue = 0;
    public Text textBox;
    void Start()
    {
            textBox = GetComponent<Text>();
    }

    void Update()
    {
        textBox.text = "Score: " + scoreValue;
    }
}
