using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float timeUntilNextEvent;
    private int eventPicker;
    public CameraShake camShake;
    public GameStats gameStats;

    


    // Start is called before the first frame update
    void Start()
    {
        timeUntilNextEvent = Random.Range(3f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        if (timeUntilNextEvent > 0)
        {
            timeUntilNextEvent -= Time.deltaTime;
        }
        else
        {
            eventPicker = Random.Range(0, 1);

            if(eventPicker == 1){

                StartTurbulence();
            }
            else
            {
                StartCall();
            }

        }

    }


    void StartTurbulence()
    {
        gameStats.turbAnnouced = false;
        StartCoroutine(camShake.shakeCamera(30));

        if(gameStats.turbAnnouced == false)
        {
            
        }


    }

    void StartCall()
    {

    }



}
