using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    private float timeBtwSpawn;
    public float StarttimeBtwSpawn;
    private Vector3 SpawnPos;
    float YPos;
    // // Start is called before the first frame update
    void Start()
    {
      
     
    }

    // // Update is called once per frame
    void Update()
    {
        YPos = Random.Range(-1.6f,2.04f);
        SpawnPos = new Vector3(transform.position.x, YPos, transform.position.z);
        if(timeBtwSpawn <= 0)
        {
            Instantiate(pipe,  SpawnPos, transform.rotation);
            timeBtwSpawn = StarttimeBtwSpawn;
        }
        else{
            // timeBtwSpawn = timeBtwSpawn - Time.deltaTime;
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
