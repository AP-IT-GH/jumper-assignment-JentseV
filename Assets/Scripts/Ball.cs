using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
     private float timeToLive;
    private Rigidbody rgb;

    public static bool Dodged,Spawned = false;

    private float moveSpeed;
    [SerializeField] private Transform agent;

    void Start()
    {
        Spawned = true;
        timeToLive = 10f;
        agent = GameObject.Find("toGo").GetComponent<Transform>();
        rgb = this.gameObject.GetComponent<Rigidbody>();
        this.transform.LookAt(agent);
        moveSpeed = Random.Range(1f,5f);
    }

    // Update is called once per frame
    void Update()
    {
        timeToLive -= Time.deltaTime;
        Move();
        Destroy();
    }

    public void Move(){
        rgb.AddForce(transform.forward * moveSpeed );
    }
    public void Destroy(){
        if(this.transform.localPosition.z > 4f || this.transform.localPosition.x < -5f){
            Dodged = true;
            Spawned = false;
            Destroy(this.gameObject);
        } else{
            Dodged = false;
        }
    }
}
