using System;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class PlayerMovement : MonoBehaviour
{
    float horizontalInput;
    public float moveSpeed = 5f;
    bool isFacingRight = false;
    public float jumpPower = 0f;
    bool isGrounded = false;
    public GameObject dayThreeArrow1;
    public GameObject dayThreeArrow2;


    Rigidbody2D rb;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        dayThreeArrow1.SetActive(false);
        dayThreeArrow2.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");

        FlipSprite();

        
    }

    private void FixedUpdate()
    {
        rb.velocity = new Vector2(horizontalInput * moveSpeed, 0);
        animator.SetFloat("xVelocity", Math.Abs(rb.velocity.x));
    }

    void FlipSprite()
    {
        if(isFacingRight && horizontalInput < 0f || !isFacingRight && horizontalInput > 0f)
        {
            isFacingRight = !isFacingRight;
            Vector3 ls = transform.localScale;
            ls.x *= -1f;
            transform.localScale = ls;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isGrounded = true;
        if(collision.gameObject.CompareTag("shelter"))
        {
            SceneManager.LoadScene(7);
        }

        if(collision.gameObject.CompareTag("Chef"))
        {
            dayThreeArrow1.SetActive(true);
            dayThreeArrow2.SetActive(true);
        }
        if (collision.gameObject.CompareTag("Day3Transition"))
        {
            SceneManager.LoadScene("Day3Transition");
        }
    }

    
}
