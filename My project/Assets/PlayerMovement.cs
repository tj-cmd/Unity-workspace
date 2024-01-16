using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float playerSpeed = 3f;
    private Rigidbody2D rb;
    private BoxCollider2D col;
    public float jumpForce;
    [SerializeField] private LayerMask jumpGround;
    private Animator anim;




    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0, 0, 0);
        rb = GetComponent<Rigidbody2D>();
        rb.freezeRotation = true;
        col = GetComponent<BoxCollider2D>();
        anim = GetComponent<Animator>();



    }


 private bool IsGrounded()
    {
         return Physics2D.BoxCast(col.bounds.center, col.bounds.size, 0f, Vector2.down, .1f, jumpGround);
    }





        // Update is called once per frame
        private void Update()
    {
        float dirX = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(dirX, 0, 0);
        transform.Translate(direction * playerSpeed * Time.deltaTime);





        if (Input.GetButtonDown("Jump") && IsGrounded()) 
        {
            rb.velocity = (new Vector2(rb.velocity.x, jumpForce));
        }


        if (dirX > 0f)
        {
            anim.SetBool("running", true);

        }
        else if (dirX < 0f)
        {
            anim.SetBool("running", true);
        }
        else
        {
            anim.SetBool("running", false);
        }
    }

}

