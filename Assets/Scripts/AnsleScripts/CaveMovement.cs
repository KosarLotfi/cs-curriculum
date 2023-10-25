using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaveMovement : MonoBehaviour
{
    float WalkingSpeed;
    float xvector;
    float xdirection; 
    float yvector;
    float ydirection; 
    float zvector;
    float zdirection; 
    bool Overwold;
    
    // Start is called before the first frame update
    void Start()
    {
        WalkingSpeed = 4;
        
    }

    // Update is called once per frame
    void Update()
    {
        //x
        xdirection = Input.GetAxis("Horizontal");
        xvector = xdirection * WalkingSpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xvector, 0, 0);
        //y
        ydirection = Input.GetAxis("Vertical");
        yvector = ydirection * WalkingSpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xvector, yvector, 0);
        //z
        zdirection = Input.GetAxis("Jump");
        zvector = zdirection * WalkingSpeed * Time.deltaTime;
        transform.position = transform.position + new Vector3(xvector, yvector, zvector);
        
    }
}
