using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Timer : MonoBehaviour
{
    public float maxTime;
    private float currentSecondfloat;
    public int currentSecond;
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
            Debug.Log(currentSecond);
        }
        else print("Timer has reacherd zero");
    }
}
