using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    private Rigidbody2D playerRB;
    [SerializeField] public GameObject playerGO;

    [SerializeField] private float jumpForce;

    [SerializeField] private float runSpeed;

    private int numberOfJumps;

    public Animator animator;

    [SerializeField] private LayerMask layerFilter;

    

    bool jumping = false;

    
    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody2D>();
        
        jumping = false;
    }

    // Update is called once per frame
    void Update()
    {
        Move();

        Jump();

        


    }

    private void Move()
    {
        float moveRight = Input.GetAxis("Horizontal") * runSpeed * Time.deltaTime;

        transform.Translate(moveRight, 0, 0);
        animator.SetFloat("Speed", moveRight);
    }


    private void Jump()
    {
        if (!jumping)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerRB.AddForce(Vector2.up * jumpForce);
                jumping = true;
                animator.SetBool("Jump", jumping);
            }

            
        }
        else
        {
            jumping = false;
            animator.SetBool("Jump", jumping);
        }
        
    }

    

    

    public void Die()
    {
        playerGO.gameObject.SetActive(false);
    }

}
