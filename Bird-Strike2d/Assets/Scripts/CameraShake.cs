using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShake : MonoBehaviour
{

    
    public AnimationCurve curve;
    public GameObject camera;
    public Positions position;
    private float timeElapsed = 0;
    
    // Update is called once per frame
    void Update()
    {
        //timeElapsed += Time.deltaTime;
    }

    void Start()
    {
       
    }

    public IEnumerator shakeCamera(float duration)
    {
        Vector3 originalPosition =  camera.transform.position;

        float durationShake = duration;

        while (timeElapsed < durationShake)
        {
            timeElapsed += Time.deltaTime;
            float strenght = curve.Evaluate(timeElapsed/durationShake);
            camera.transform.position = position.camPos + Random.insideUnitSphere * strenght;
            yield return null;

        }

        camera.transform.position = originalPosition;
    }
}
