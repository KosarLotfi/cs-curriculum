using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneTemplate;
using UnityEngine;
using Input = UnityEngine.Windows.Input;

public class FireBall : MonoBehaviour
{
    public Vector3 target;
    public GameObject self;
    public float timer;
    float originaltimer;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        originaltimer = 6;
        target = player.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position=(Vector3.MoveTowards(transform.position, target, 0.005f));
           
    }
}
