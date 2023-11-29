using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.SceneTemplate;
using UnityEditor.UI;
using UnityEngine;
using Input = UnityEngine.Windows.Input;

public class FireBall : MonoBehaviour
{
    public Vector3 target;
    float originaltimer;
    private GameObject player;

    public PlayerMovement pms;

    public GameObject self;

    public Collider2D FireballCollider;

    [SerializeField] Vector3 targetLocation;

    [SerializeField] float LifeSpan;
    // Start is called before the first frame update
    void Start()
    {
        pms = GameObject.FindObjectOfType<PlayerMovement>();
        if (pms.ydirection > 0)
        {
            targetLocation = new Vector3(transform.position.x, transform.position.y + 1000,
                transform.position.z + 1000);
        }
        else if (pms.ydirection < 0)
        {
            targetLocation = new Vector3(transform.position.x, transform.position.y - 1000,
                transform.position.z - 1000);
        }
        if (pms.xdirection > 0)
        {
            targetLocation = new Vector3(transform.position.x, transform.position.y + 1000,
                transform.position.z + 1000);
        }
        else if (pms.xfirediraction < 0)
        {
            targetLocation = new Vector3(transform.position.x, transform.position.y -1000,
                transform.position.z - 1000);
        }
        else
        {
            targetLocation = transform.position;
        }
        player = GameObject.FindGameObjectWithTag("Player");
        originaltimer = 6;
        target = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        LifeSpan -= Time.deltaTime;
        if (LifeSpan < 5.95)
        {
            FireballCollider = GetComponent<Collider2D>();
            FireballCollider.isTrigger = false;
        }

        if (LifeSpan < 0)
        {
            Destroy(self);
        }
        transform.position=(Vector3.MoveTowards(transform.position, target, 0.005f));
        
    }

   
}
