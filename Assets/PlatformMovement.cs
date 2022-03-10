using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMovement : MonoBehaviour
{

    public float platformSpeed;

    private float yPos;

    private Vector3 platformMove;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        yPos = Time.deltaTime*platformSpeed;

        platformMove = new Vector3(0, yPos, 0);

        transform.position += platformMove;


    }
}
