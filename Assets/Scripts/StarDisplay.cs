using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StarDisplay : MonoBehaviour
{
    [SerializeField] int starCount = 100;
    Text starText;
    void Start()
    {
        starText = GetComponent<Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        starText.text = starCount.ToString();
    }

    public void AddStars(int amount)
    {
        starCount += amount;
        UpdateDisplay();
    }

    public void SpendStars(int amount)
    {
        starCount -= amount;
        UpdateDisplay();
    }
}
