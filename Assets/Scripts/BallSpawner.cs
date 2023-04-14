using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    [SerializeField] private GameObject ballPrefab;
    // Start is called before the first frame update
    void Start()
    {
        
        StartCoroutine(SpawnBall());
    }

    public IEnumerator SpawnBall(){
        while(true){
            Instantiate(ballPrefab,this.transform.position,Quaternion.identity);
            yield return new WaitForSeconds(20f);
        }
       
    }
}
