using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class treeSpawner : MonoBehaviour
{
    public GameObject tree;
    private float timeBtwSpawn;
    public float StarttimeBtwSpawn;
    
    // private Vector3 SpawnPos;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // SpawnPos = new Vector3(transform.position.x, transform.position.z);
        if(timeBtwSpawn <= 0)
        {
            Instantiate(tree);
            timeBtwSpawn = StarttimeBtwSpawn;
        }
        else{
          
            timeBtwSpawn -= Time.deltaTime;
        }
    }
}
