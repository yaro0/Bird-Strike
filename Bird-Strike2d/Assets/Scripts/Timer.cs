using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
    public float maxTime;
    private float currentSecondfloat;
    public int currentSecond;
    public TMP_Text time;
    // Start is called before the first frame update
    void Start()
    {
        currentSecondfloat = maxTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (currentSecondfloat > 0)
        {
            currentSecondfloat -= Time.deltaTime;
            currentSecond = (int)currentSecondfloat;
            time.text = currentSecond.ToString(); 

        }
        else print("Timer has reacherd zero");
    }
}
