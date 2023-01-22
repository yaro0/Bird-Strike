using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonPress : MonoBehaviour
{
    public GameObject camera;
    public GameObject leftUI;
    public GameObject frontUI;
    public GameObject rightUI;

    public void interact(string text)
    {
        SceneManager.LoadScene(sceneName: text, LoadSceneMode.Additive);

    }

    public void closeScene(string text)
    {
        SceneManager.UnloadSceneAsync(sceneName: text);
            
    }

    public void goToleft()
    {
        camera.transform.position = new Vector3(-30, camera.transform.position.y, -10);
        frontUI.SetActive(false); 
        leftUI.SetActive(true); 

    }

    public void goToRight()
    {
        camera.transform.position = new Vector3(30, camera.transform.position.y, -10);
        frontUI.SetActive(false);
        rightUI.SetActive(true);
    }

    public void goToFront()
    {
        camera.transform.position = new Vector3(0, 0, -10);
        frontUI.SetActive(true);
        leftUI.SetActive(false);
        rightUI.SetActive(false);

    }

}
