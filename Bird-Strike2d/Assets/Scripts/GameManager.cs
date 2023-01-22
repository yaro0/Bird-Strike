using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public float timeUntilNextEvent;
    private int eventPicker;
    public CameraShake camShake;
    public GameStats gameStats;
    private bool eventOngoing = false;

    


    // Start is called before the first frame update
    void Start()
    {
        timeUntilNextEvent = Random.Range(5f, 10f);
        print(timeUntilNextEvent);
    }

    // Update is called once per frame
    void Update()
    {
        //print(eventOngoing);
        if (timeUntilNextEvent > 0)
        {
            timeUntilNextEvent -= Time.deltaTime;
        }
        else if(eventOngoing == false){

            eventPicker = Random.Range(0, 2);
            print(eventPicker);

            if(eventPicker == 1){

                gameStats.turbulenceOngoing = true;
                StartCoroutine(StartTurbulence());

            }
            else
            {
                StartCall();
            }

        }

    }


    public IEnumerator StartTurbulence()
    {
        eventOngoing = true;
        
        StartCoroutine(camShake.shakeCamera(30));
        yield return new WaitForSeconds(25);

        if (gameStats.turbAnnouced == false && gameStats.healthLeft > 0)
        {
            gameStats.healthLeft--;
        }


        eventOngoing = false;
        gameStats.turbulenceOngoing = false;
        timeUntilNextEvent = Random.Range(5f, 10f);
        gameStats.turbAnnouced = false;

    }

    void StartCall()
    {

    }

    


}
