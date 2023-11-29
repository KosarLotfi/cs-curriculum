using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
   public float xSpeed;
    public float ySpeed;
    float jumpForce;
   public float xvector;
   public float xdirection; 
  public  float yvector;
    public float ydirection; 
   public float zvector;
    float zdirection; 
    public bool Overwold;
    public float xfirediraction;
    public float yfirediraction;
    public KeyCode sprintkey;
    
    // Start is called before the first frame update
    void Start()
    {
        xSpeed = 4;
        if (Overwold)
        {
            jumpForce = 0;
            ySpeed = 4;
        }
        else
        {
            ySpeed = 0;

        }
        
        

    }

    // Update is called once per frame
    void Update()
    {
        //x
        xdirection = Input.GetAxis("Horizontal");
        xvector = xdirection * xSpeed * Time.deltaTime;
        if (xdirection != 0)
        {
            xfirediraction = xdirection;
            yfirediraction = 0;
        }
        //y
        ydirection = Input.GetAxis("Vertical");
        yvector = ydirection * ySpeed * Time.deltaTime;
        if (ydirection != 0)
        {
            yfirediraction = ydirection;
            xfirediraction = 0;
        }
        //z
        zdirection = Input.GetAxis("Jump");
        yvector =  ySpeed * ydirection * Time.deltaTime; 
        
        transform.position =  transform.position + new Vector3(xvector, yvector, zvector);

        
        }
        
    }

