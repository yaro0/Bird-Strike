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
        timeUntilNextBird = Random.Range(10, 15);
        
    }

    // Update is called once per frame
    void Update()
    {
        
        
            if (timeUntilNextBird > 0)
            {
                timeUntilNextBird -= Time.deltaTime;
            }
            else NewBird();
        
        
        

    }
    void NewBird()
    {
        int leftOrRIght=Random.Range(1,3);
        Debug.Log("leftOrRIght=" + leftOrRIght);
        if(leftOrRIght == 1)
        {

            positionNextBird = new Vector3(Random.Range(-20f, -16f), Random.Range(1f, 3f), 0f);
            Instantiate(birdPrefab, positionNextBird, this.transform.rotation);
            
        }
        if(leftOrRIght == 2)
        {
            positionNextBird = new Vector3(Random.Range(20f, 16f), Random.Range(1f, 3f), 0f);
            Instantiate(birdPrefab, positionNextBird, this.transform.rotation);
            
        }
        
        //Instantiate(birdPrefab, positionNextBird, this.transform.rotation);
        timeUntilNextBird = Random.Range(10, 15);
    }

    
    
}
