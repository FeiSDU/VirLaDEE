using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody player; //variable refers to Transfom in the scene
    //public float speed = 1f;
    public float forceMultiplier = 10f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 moveDirection = Vector3.zero;

        float horizontalInput = Input.GetAxis("Horizontal");
        moveDirection += new Vector3(x:horizontalInput, y:0f, z:0f);

        float verticalInput = Input.GetAxis("Vertical");
        moveDirection += new Vector3(x: 0f, y: 0f, z: verticalInput);
        //Vector3 moveDelta = moveDirection * speed * Time.deltaTime;

        Vector3 movingForce = moveDirection * forceMultiplier;
        
        player.AddForce(movingForce);

        //player.position += moveDelta;
    }
}
