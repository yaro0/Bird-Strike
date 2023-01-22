using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class StrikeNum : MonoBehaviour
{
    [SerializeField] private TMP_Text text;
    [SerializeField] private GameStats gameStats;
    private float oneSecondwait = 1f;

    void Update()
    {
        int numOfStikes = 3 - gameStats.healthLeft;
        text.text = numOfStikes.ToString(); 

        if(numOfStikes == 3)
        {
            if (oneSecondwait > 0)
            {
                oneSecondwait -= Time.deltaTime;

            }
            else SceneManager.LoadScene(2);
        }
    }
}
