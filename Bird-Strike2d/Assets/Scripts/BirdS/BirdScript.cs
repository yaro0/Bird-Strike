using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public Transform transform;
    public int leftOrRight;
    public Sprite crashedBird;
    public bool birdCrashed=false;
    
    private SpriteRenderer sp;
    // Start is called before the first frame update
    void Start()
    {
        sp = gameObject.GetComponent<SpriteRenderer>();

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
        if (!birdCrashed)
        {
            transform.localScale += new Vector3(Mathf.Sign(transform.localScale.x) * 0.0015f, Mathf.Sign(transform.localScale.y) * 0.0015f, 0);
        }
       
        if (transform.localScale.x > 4f || transform.localScale.x<-4f)
        {
            birdCrash();
            Cursor.lockState = CursorLockMode.Locked;
            Cursor.visible = false;
        }
        
    }
    void OnMouseDown()
    {
        if (!birdCrashed)
        {
            Destroy(gameObject);
        }
    }

    void birdCrash()
    {
        sp.sprite = crashedBird;
        gameObject.GetComponent<Animator>().enabled = false;
        rb.velocity = new Vector2(0f, 0f);
        birdCrashed = true;
        
        //gameObject.SetActive(false);
    }
}
