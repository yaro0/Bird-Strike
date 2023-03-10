using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurbulenceButton : MonoBehaviour
{

    [SerializeField] private GameStats gameStats;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Button button;
    [SerializeField] private GameObject noTurbMessage;
    //[SerializeField] TextMeshPro text; 

    // Start is called before the first frame update
    void Start()
    {
        noTurbMessage.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (gameStats.turbAnnouced)
        {

        }


    }

    public void announceTurb()
    {
        if (gameStats.turbulenceOngoing && !gameStats.turbAnnouced) { 
        button.enabled = false;
        StartCoroutine(playAnnoucement());

        if (!gameStats.turbAnnouced)
        {
            gameStats.turbAnnouced = true;
        }

        
    } else {

            StartCoroutine(noTurb());
    }

    }

    public IEnumerator playAnnoucement()
    {
        GetComponent<Button>().interactable = false;
        noTurbMessage.SetActive(false);
        audioSource.Play();

        yield return new WaitForSeconds(5);
        
        button.enabled = true;
        GetComponent<Button>().interactable = true;
    }

    public IEnumerator noTurb()
    {
        noTurbMessage.SetActive(true);

        yield return new WaitForSeconds(3);
        print("here");
        noTurbMessage.SetActive(false);

    }
}
