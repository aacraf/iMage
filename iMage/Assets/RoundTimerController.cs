using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RoundTimerController : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 10f;
    bool counting = false;

    public TextMeshProUGUI timerText;

    void Start()
    {
        currentTime = startingTime;
    }

    void Update()
    {
        if (counting)
        {
            currentTime -= 1 * Time.deltaTime;
            timerText.text = ((int)currentTime).ToString();
            if (currentTime <= 0f)
            {
                counting = false;
                TimesUp();
            }
        }
        
    }

    public void StartTimer()
    {
        counting = true;
    }

    void TimesUp()
    {
        Debug.Log("sacabado el tiempo");
        //TODO
    }
}
