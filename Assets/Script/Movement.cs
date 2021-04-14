using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private int speed=10;
    [SerializeField] private float gravity = 9.8f;
    [SerializeField] private float height = 1.8f;
    private bool canJump = true;
    [SerializeField] private float jumpForce = 4;
    private Animator _anim;
    private bool right = false;
    private bool left = false;
    private void Awake()
    {
        _anim = GetComponent<Animator>();
    }

    public void onRightup()
    {
        right = false;
    }
    public void onRightDown()
    {
        right = true;
    }
    public void onLeftup()
    {
        left = false;
    }
    public void onLeftDown()
    {
       left = true;
    }
    void Update() // Update is called once per frame
    {
        ClampPosition();
        Move();
        swipeleftMovement();
        swipeRightMovement();
    }
   
    /*private void jump()
    {
        if (Input.GetKey(KeyCode.Space))
        {    RaycastHit hit;
            Ray landingRay = new Ray(transform.position, Vector3.down);
            Debug.DrawRay(transform.position, Vector3.down * height,Color.red);

            if (Physics.Raycast(landingRay, out hit, height))
            {
                print(hit.collider.gameObject.name);
                if (hit.collider.gameObject.CompareTag("Ground"))
                {   
                   _anim.SetTrigger("jump");
                    transform.Translate(Vector3.up * (Time.deltaTime * jumpForce));
                }
               
            }
        }
    }*/
    private void ArtiGravity()
    {
        if (transform.position.y > 2.9)
        {
            transform.Translate(Vector3.down * (Time.deltaTime * gravity));
        }
    }

    private void sendRay()
    {
        RaycastHit hit;
        Ray landingRay = new Ray(transform.position, Vector3.down);
        Debug.DrawRay(transform.position, Vector3.down * height,Color.red);
 
        if (Physics.Raycast(landingRay, out hit, height))
        {
            if (hit.collider.gameObject.CompareTag("Ground"))
            {
                print("hoi");
            }
            
            if (hit.collider.gameObject.tag == "Ground")
            {  
                canJump = true;
              //  ArtiGravity();
                //Debug.Log(canJump);
            }
            else if(hit.collider.gameObject.tag != "Ground")
            {
                canJump = false;
                //Debug.Log(canJump);
            }
           // Debug.Log(canJump);
        }
    }
    private void ClampPosition()
    {
        if (transform.position.x > 2.7f)
        {
            transform.position = new Vector3(2.7f, transform.position.y, transform.position.z);
        }
        if (transform.position.x < -2.7f)
        {
            transform.position = new Vector3(-2.7f, transform.position.y, transform.position.z);
        }
    }

    private void Move()
    {
        transform.Translate(Vector3.forward * (Time.deltaTime * speed),Space.World);
        MoveLeft();
        MoveRight();
    }
    private void MoveRight()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * (Time.deltaTime * speed),Space.World);
        }
    }

    private void MoveLeft()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * (Time.deltaTime * speed),Space.World);
        }
    }

    public void swipeRightMovement()
    {
        if (right == true)
        {
            Debug.Log("right");
            transform.Translate(Vector3.right * (Time.deltaTime * speed),Space.World);
        }
      
   
        
    }
    
    public void swipeleftMovement()
    {
        if (left == true)
        {
            Debug.Log("left");
            transform.Translate(Vector3.left * (Time.deltaTime * speed),Space.World);
        }
      
  
    }
}
