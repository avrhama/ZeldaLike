using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour{
    public float speed;
    private Rigidbody2D myRigidbody;
    Vector2 change;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        myRigidbody = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        change = Vector2.zero;
       
        change.x=Input.GetAxisRaw("Horizontal");
        change.y=Input.GetAxisRaw("Vertical");
       


    }
    void UpdateAnimationAndMove()
    {
        if (change != Vector2.zero)
        {
            MoveCharacter();
            animator.SetFloat("moveX", change.x);
            animator.SetFloat("moveY", change.y);
            animator.SetBool("moving", true);
        }
        else
        {
            animator.SetBool("moving", false);
        }
    }
    private void FixedUpdate()
    {
        UpdateAnimationAndMove();
    }
    public void MoveCharacter()
    {
      
        myRigidbody.MovePosition(myRigidbody.position + change * speed * Time.deltaTime);
    }
}
