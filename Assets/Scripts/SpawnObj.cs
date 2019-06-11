using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObj : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objToSpawn;
    public Vector3 spawnValues;
    public float spawnWait;
    public float spawnLeastWait;
    public float spawnMostWait;
    public int startWait;

    int randEnemy;
    public bool stop;

    void Start()
    {
        StartCoroutine(waitSpawner());
    }

    // Update is called once per frame
    void Update()
    {
      spawnWait=Random.Range(spawnLeastWait,spawnMostWait);
    }

    IEnumerator waitSpawner()
    {
        while(!stop)
        {
       randEnemy=Random.Range(0,2);
       Vector3 spawnposition = new Vector3(Random.Range(-3,3),1.5f,7);
       Instantiate(objToSpawn,spawnposition,transform.rotation);
        yield return new WaitForSeconds(spawnWait);
        }
    }
}
