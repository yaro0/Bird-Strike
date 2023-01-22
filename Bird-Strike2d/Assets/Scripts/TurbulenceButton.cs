using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurbulenceButton : MonoBehaviour
{

    [SerializeField] private GameStats gameStats;
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private Button button;
    //[SerializeField] TextMeshPro text; 

    // Start is called before the first frame update
    void Start()
    {

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
    print("no turbulence");

    }

    }

    public IEnumerator playAnnoucement()
    {
        audioSource.Play();

        yield return new WaitForSeconds(3);
        
        button.enabled = true;

    }
}
