using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPress : MonoBehaviour
{
    public void interact(string text)
    {
        SceneManager.LoadScene(sceneName: text, LoadSceneMode.Additive);

    }

    public void closeScene(string text)
    {
        SceneManager.UnloadSceneAsync(sceneName: text);
            
    }
}
