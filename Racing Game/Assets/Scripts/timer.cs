using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class timer : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 3f;
    [SerializeField] Text Countdown;
    // Start is called before the first frame update
    void Start()
    {
        currentTime = startingTime;
    }
    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        Countdown.text = currentTime.ToString("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            Destroy(Countdown);
        }
    }
}
