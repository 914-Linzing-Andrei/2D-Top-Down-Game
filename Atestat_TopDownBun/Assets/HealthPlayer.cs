using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

public class HealthPlayer : MonoBehaviour
{
    public Text textBox;
    void Start()
    {
        textBox.text = Convert.ToString(GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().health);
    }

    void Update()
    {
        textBox.text = Convert.ToString(GameObject.FindGameObjectWithTag("Player").GetComponent<Player>().health);
    }
}
