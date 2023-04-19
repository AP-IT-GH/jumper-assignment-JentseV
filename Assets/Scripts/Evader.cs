using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.MLAgents;
using Unity.MLAgents.Sensors;
using Unity.MLAgents.Actuators;

public class Evader : Agent
{
    
    private float timeAlive = 0F;
    private float totalTimeAlive= 0f;
    private bool canJump = true, hit;

  
  
   
    private Rigidbody rgb;

    public override void OnEpisodeBegin()
    {
       
        Debug.Log("Started");
        hit = false;
        rgb = this.GetComponent<Rigidbody>();
        timeAlive = 0f;
        totalTimeAlive = 0f;
    }


    public override void CollectObservations(VectorSensor sensor)
    {
        sensor.AddObservation(this.transform.localPosition);
        sensor.AddObservation(timeAlive);
        sensor.AddObservation(canJump);
    }

    public override void OnActionReceived(ActionBuffers actions)
    {

        timeAlive += Time.deltaTime;
        
        Debug.Log(GetCumulativeReward());
        

        // if(timeAlive > 200f){
        //     AddReward(1f);
        //     EndEpisode();
        // }

        if(actions.DiscreteActions[0] == 1 && canJump){
            Jump();
            AddReward(-0.1f);
        }

    }


    public override void Heuristic(in ActionBuffers actionsOut)
    {
        if(Input.GetKeyDown(KeyCode.Space) && canJump){
            Jump();
        }
    }


    private void OnTriggerEnter(Collider other)
     {
        if(other.gameObject.tag == "Ball"){
            hit = true;
            Debug.Log("Didnt dodge the ball");
            AddReward(-2f);
            EndEpisode();
        }   
    }


    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.tag == "Floor" )
        {
            canJump = true;
        }
    }

    private void OnCollisionExit(Collision other) {
        if(other.gameObject.tag == "Floor")
        {
            canJump = false;
        }
    }

    private void Jump()
    {
        if(canJump){
            rgb.AddForce(Vector3.up * 2.5f, ForceMode.Impulse);
        }
        
    }

}
