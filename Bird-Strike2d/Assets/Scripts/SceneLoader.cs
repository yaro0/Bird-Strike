using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{

    public GameStats gamestats;

    public void LoadScene(int level)
    {
        SceneManager.LoadScene(level);
        gamestats.healthLeft = 3;
        gamestats.turbAnnouced = false;
        gamestats.turbulenceOngoing = false;
        gamestats.callAnswered = false;

    }


}
