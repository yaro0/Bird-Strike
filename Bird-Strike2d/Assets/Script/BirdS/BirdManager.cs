using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdManager : MonoBehaviour
{
    public float timeUntilNextBird;
    public Transform positionNextBird;
    public GameObject birdPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // timeUntilNextBird = Random(3, 15);
        if(timeUntilNextBird == 0)
        {
            //Instantiate(birdPrefab, positionNextBird, Quaternion.identity);
        }
    }
}
