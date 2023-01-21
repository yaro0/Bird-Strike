using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdManager : MonoBehaviour
{
    public float timeUntilNextBird;
    public Vector3 positionNextBird;
    public GameObject birdPrefab;

    // Start is called before the first frame update
    void Start()
    {
        timeUntilNextBird = Random.Range(3, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if(timeUntilNextBird > 0)
        {
            timeUntilNextBird-=Time.deltaTime;
        }else NewBird();
        

    }
    void NewBird()
    {
        positionNextBird = new Vector3(Random.Range(-20f, -16f), Random.Range(-5f, 5f), 0f);
        Instantiate(birdPrefab, positionNextBird, this.transform.rotation);
        timeUntilNextBird = Random.Range(3, 5);
    }
    
}