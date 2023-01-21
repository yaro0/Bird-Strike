using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public Transform transform;
    // Start is called before the first frame update
    void Start()
    {
        rb.velocity = transform.right * speed;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale +=  new Vector3(0.0006f, 0.0002f, 0);
        
    }
    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
