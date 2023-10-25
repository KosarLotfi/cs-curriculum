using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallTurret : MonoBehaviour
{
    GameObject target = null; 
    public float timer;
    public float originaltimer;

    [SerializeField] private GameObject projectile;
    // Start is called before the first frame update
    void Start()
    {
        originaltimer = 2;
        timer = originaltimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (target != null)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                Instantiate(projectile, transform.position, Quaternion.identity);
                timer = originaltimer;
            }
            
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target = other.gameObject;
           
        }
    }
    
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            target = null;
        }
    }
}
