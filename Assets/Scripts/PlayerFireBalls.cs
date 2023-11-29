using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class PlayerFireBalls : MonoBehaviour
{
    public KeyCode shootkey;

    public GameObject PlayerFireball;

    public bool cooldown;

    public float cooldownTimer;

    public float ogCooldownTimer;
    
    // Start is called before the first frame update
    void Start()
    {
        cooldownTimer = ogCooldownTimer;
        shootkey = KeyCode.X;
    }

    // Update is called once per frame
    void Update()
    {
        if (!cooldown)
        {
            if (Input.GetKeyDown(shootkey))
            {
                Instantiate(PlayerFireball, transform.position, Quaternion.identity);
                cooldown = runInEditMode;
            }
        }

        if (cooldown)
        {
            cooldownTimer -= Time.deltaTime;
            if (cooldownTimer < 0)
            {
                cooldownTimer = ogCooldownTimer;
                cooldown = false;
            }
        }
    }
}
