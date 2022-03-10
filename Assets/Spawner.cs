using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public PlayerMovement playerScript;

    public GameObject platforms;

    public float range = 3;


    public void Start()
    {
        StartCoroutine(spawnObject());
    }
    public IEnumerator spawnObject()
    {
        while (!playerScript.isDead)
        {
            
            Instantiate(platforms,new Vector3(Random.Range(-range,+range), -6, 0), Quaternion.identity);
            yield return new WaitForSeconds(2.5f); 
            
        }

    }
}
