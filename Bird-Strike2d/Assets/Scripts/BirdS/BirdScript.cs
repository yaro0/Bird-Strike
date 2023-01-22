using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdScript : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    public Transform transform;
    public int leftOrRight;
    public Sprite crashedBird;
    public bool birdCrashed=false;
    public GameObject particles;
    private float oneSecondwait = 1f;
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
        
       
        if (transform.localScale.x > 4f || transform.localScale.x<-4f)
        {
            birdCrash();
            
            
            if (oneSecondwait > 0)
            {
                oneSecondwait -= Time.deltaTime;

            }else SceneManager.LoadScene(1);
        }
        
    }
    void FixedUpdate()
    {
        if (!birdCrashed)
        {
            transform.localScale += new Vector3(Mathf.Sign(transform.localScale.x) * 0.009f, Mathf.Sign(transform.localScale.y) * 0.009f, 0);
        }
    }
    void OnMouseDown()
    {
        if (!birdCrashed)
        {
            Instantiate(particles, transform.position, transform.rotation);
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
