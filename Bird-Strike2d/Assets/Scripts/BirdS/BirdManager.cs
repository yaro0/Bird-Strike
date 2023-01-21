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
        
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilNextBird = Random.Range(3, 15);
        positionNextBird = new Vector3(Random.Range(-20f, -16f), Random.Range(-5f, 5f), 0f);
        if(timeUntilNextBird == 0)
        {
            Instantiate(birdPrefab, positionNextBird, this.transform.rotation);
        }
        else
        {
            timeUntilNextBird -= Time.deltaTime;
        }
    }
}
