using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timerUP : MonoBehaviour
{
    public float timeStart;
    public Text textBox;
    void Start()
    {
        textBox.text = timeStart.ToString();
    }

    void Update()
    {
        timeStart += Time.deltaTime;
        textBox.text = Mathf.Round(timeStart).ToString();
    }
}
