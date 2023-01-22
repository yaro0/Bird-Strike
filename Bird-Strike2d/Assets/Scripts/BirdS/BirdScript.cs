using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public Transform transform;
    public int leftOrRight;
    // Start is called before the first frame update
    void Start()
    {
        if (transform.position.x<0f)
        {
            rb.velocity = transform.right * speed;
        }
        if(transform.position.x>0f)
        {
            rb.velocity = transform.right*-1 * speed;
            transform.localScale = new Vector3(-1, 1, 1);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale +=  new Vector3(Mathf.Sign(transform.localScale.x)*0.006f, Mathf.Sign(transform.localScale.y)*0.002f, 0);
        
    }
    void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
