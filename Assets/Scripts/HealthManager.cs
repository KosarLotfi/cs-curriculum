using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class HealthManager : MonoBehaviour
{
    bool iframes;
    
    float originaltimer;
    float timer;
    

    private HUD hud;
    // Start is called before the first frame update
    void Start()
    {
        hud = GameObject.FindObjectOfType<HUD>();
        originaltimer = 1.5f;
      timer = originaltimer;
    }

    // Update is called once per frame
    void Update()
    {
        if (iframes)
        {
            timer -= Time.deltaTime;
            if (timer < 0)
            {
                iframes = false;
                timer = originaltimer;
            }
        }
    }

   void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spikes"))
        {
            changehealth(-1);
        }
        if (other.gameObject.CompareTag("FireBall"))
        {
            changehealth(-2);
            Destroy(other.gameObject);
        }
        
    }

   void OnTriggerEnter2D(Collider2D other)
   {
       if (other.gameObject.CompareTag("Heart"))
       {
           changehealth(+2);
           Destroy(other.gameObject);
       }
      
   }
   
   void changehealth(int amount)
   {
       if (amount > 0 && hud.health != hud.maxhealth)
       {
           hud.health += amount;
           
       }
       
       if (hud.health > hud.maxhealth)
       {
           hud.health = hud.maxhealth;
       }

   else if (!iframes)
       {
           iframes = true;
           hud.health += amount;
       }
       
       
   }
}
