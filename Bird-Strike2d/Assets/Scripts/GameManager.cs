using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public float timeUntilNextEvent;
    private int eventPicker;
    public CameraShake camShake;
    public GameStats gameStats;
    private bool eventOngoing = false;
    
    public TMP_Text callText;
    public GameObject exclamationMark;
    public Button callButton;
    public Button redButton;
    public Button purpleButton;
    public Button blueButton;
    public Button greenButton;

    // Start is called before the first frame update
    void Start()
    {
        timeUntilNextEvent = Random.Range(5f, 10f);
        print(timeUntilNextEvent);
    }

    // Update is called once per frame
    void Update()
    {
        
        if (timeUntilNextEvent > 0)
        {

            timeUntilNextEvent -= Time.deltaTime;
        }
        else if(eventOngoing == false && !gameStats.turbAnnouced && !gameStats.callOngoing)
        {

            eventPicker = Random.Range(0, 2);
            print(eventPicker);

            if(eventPicker == 1){

                gameStats.turbulenceOngoing = true;
                StartCoroutine(StartTurbulence());

            }
            else
            {
                gameStats.callOngoing = true;
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
        eventOngoing = true;
        gameStats.callOngoing = true;
        exclamationMark.SetActive(true);
        callText.text = "Incoming Message";

        if (!gameStats.callAnswered) { 
        callButton.onClick.AddListener(writeMessage);
       }

    }

    public void writeMessage()
    {
        StartCoroutine(writeMessageCoroutine());
    }


    public IEnumerator writeMessageCoroutine()
    {
        int callEventPicker = Random.Range(0, 5);
        gameStats.callAnswered = true;
        switch (callEventPicker)
        {
            case 1:
                callText.text = "Press red button";
                redButton.onClick.AddListener(rightButtonPressed);
                break;
            case 2:
                callText.text = "Press blue button";
                blueButton.onClick.AddListener(rightButtonPressed);
                break;
            case 3:
                callText.text = "Press green button";
                greenButton.onClick.AddListener(rightButtonPressed);
                break;
            case 4:
                callText.text = "Press purple button";
                purpleButton.onClick.AddListener(rightButtonPressed);
                break;
            default:
                break;
        }

        yield return new WaitForSeconds(5);
        callText.text = "";

        if (!gameStats.rightButtonPressed && gameStats.healthLeft > 0)
        {
            gameStats.healthLeft--;
        }

        exclamationMark.SetActive(false);
        gameStats.callOngoing = false;
        gameStats.callAnswered = false;
        eventOngoing = false;
        gameStats.rightButtonPressed = false;
        timeUntilNextEvent = Random.Range(5f, 10f);

    }

    void rightButtonPressed()
    {
        exclamationMark.SetActive(false);
        gameStats.rightButtonPressed = true;
    }




}
