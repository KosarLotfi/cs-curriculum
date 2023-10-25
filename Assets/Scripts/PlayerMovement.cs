using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float xSpeed;
    float ySpeed;
    float jumpForce;
    float xvector;
    float xdirection; 
    float yvector;
    float ydirection; 
    float zvector;
    float zdirection; 
    public bool Overwold;
    
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
        
        //y
        ydirection = Input.GetAxis("Vertical");
        yvector = ydirection * ySpeed * Time.deltaTime;
        
        //z
        zdirection = Input.GetAxis("Jump");
        yvector =  ySpeed * ydirection * Time.deltaTime; 
        
        transform.position =  transform.position + new Vector3(xvector, yvector, zvector);
        
    }
}
