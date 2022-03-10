using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public bool isDead = false;
    float xPos;

    [SerializeField] float moveSpeed = 10f;

    private Rigidbody2D theRB;

    // Start is called before the first frame update
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        xPos = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;;

        Vector3 movement = new Vector3(xPos, 0, 0);

        transform.position += movement;

        //theRB.AddForce(movement);
    }
}
