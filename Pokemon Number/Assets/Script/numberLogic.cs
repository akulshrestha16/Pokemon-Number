using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class numberLogic : MonoBehaviour
{
    [SerializeField] int max;
    [SerializeField] int min;
    int average;
    [SerializeField] TextMeshProUGUI guess;
    void Start()
    {
        onPressAction();

    }

    public void onPressHigher()
    {
        min = average - 1;
        onPressAction();
    }

    public void onPressLower()
    {
        max = average + 1;
        onPressAction();
    }

    void onPressAction()
    {
        average = Random.Range(min, max +1);
        guess.text = average.ToString();
    }
}
