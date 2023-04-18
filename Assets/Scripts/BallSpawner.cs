using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    [SerializeField] private float startTime;

    [SerializeField] private List<Transform> ballSpawners;
    private bool started = false;
    private float timer = 0;

    void Start()
    {
        StartCoroutine(SpawnBall());
    }

    void Update()
    {
        
    }

    public IEnumerator SpawnBall(){
        
        while(true){
            Instantiate(ballPrefab,ballSpawners[Random.Range(0,2)].localPosition,Quaternion.identity);
            yield return new WaitForSeconds(20f);
        }
       
    }
}
