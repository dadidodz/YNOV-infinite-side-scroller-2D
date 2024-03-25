using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovements : MonoBehaviour
{
    public Rigidbody2D rb;
    public float jumpForce;
    public Vector3 boxSize;
    public float posY;
    public float posX;
    public LayerMask layerMask;
    private bool grounded;
    public bool isAlive = true;

    int nbJump = 2;
    
    public Animator animator;
    AnimatorClipInfo[] animatorinfo;
    string current_animation;
    void Start(){
        animator = GetComponent<Animator>();
    }

    void Update(){
        if (isAlive){

            GroundCheck();
                // Input.anyKeyDown && grounded && !Input.GetKeyDown(KeyCode.Escape)
            if (Input.GetKeyDown(KeyCode.Space) && nbJump > 0 && nbJump < 3){
                
                // rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                // GetComponent<Rigidbody2D>().velocity = new Vector2(0, 30);
                switch(nbJump){
                    case 1:
                        GetComponent<Rigidbody2D>().velocity = Vector2.up * (jumpForce / 1.1F);
                        nbJump--;
                        break;
                    case 2:
                        GetComponent<Rigidbody2D>().velocity = Vector2.up * jumpForce;
                        nbJump--;
                        break;
                    default:
                        // code block
                        break;
                    }
                
                
            }
                animator.SetFloat("yVelocity", rb.velocity.y);
                
        }
        // animatorinfo = animator.GetCurrentAnimatorClipInfo(0);
        // current_animation = animatorinfo[0].clip.name;
        // Debug.Log(current_animation);
    }

    void OnDrawGizmos(){
        Gizmos.color = Color.red;
        Gizmos.DrawCube(transform.position-transform.up*posY-transform.right*posX, boxSize);
    }

    void GroundCheck(){
        if (Physics2D.BoxCast(transform.position, boxSize, 0, -transform.up, posY, layerMask)){
            grounded = true;
            animator.SetBool("Grounded", grounded);
        } else {
            grounded = false;
            animator.SetBool("Grounded", grounded);
            animator.SetBool("GroundedPlatform", false);
            
        }
    }

    void OnCollisionEnter2D(Collision2D collision){
        // Debug.Log(collision.gameObject.name);
        if (collision.collider.CompareTag("Platform"))
        {
            animator.SetBool("GroundedPlatform", true);
            if(nbJump != 2 ){
                nbJump = 2;
            }
        }

        if (collision.collider.CompareTag("Ground")){
            if(nbJump != 2 ){
                nbJump = 2;
            }
        }

        if (collision.collider.CompareTag("Spikes")){
            isAlive = false;
            animator.SetBool("isAlive", isAlive);

        }
    }

    
    
}
