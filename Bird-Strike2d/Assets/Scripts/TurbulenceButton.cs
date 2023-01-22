using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurbulenceButton : MonoBehaviour
{

    [SerializeField] private GameStats gameStats;
    [SerializeField] private AudioSource audioSource;

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

        StartCoroutine(playAnnoucement());

        if (!gameStats.turbAnnouced) {
            gameStats.turbAnnouced = true;
        }


    }

    public IEnumerator playAnnoucement()
    {
        audioSource.Play();

        yield return new WaitForSeconds(3);

    }
}
