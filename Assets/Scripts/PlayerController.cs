using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using Zinnia.Action;
using Vector3 = UnityEngine.Vector3;

public class PlayerController : MonoBehaviour
{

    public Vector2Action moveInput;
    
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

        //float horizontalInput = Input.GetAxis("Horizontal");
        moveDirection += new Vector3(moveInput.Value.x, 0f, 0f);

        //float verticalInput = Input.GetAxis("Vertical");
        moveDirection += new Vector3(0f, 0f, moveInput.Value.y);
        //Vector3 moveDelta = moveDirection * speed * Time.deltaTime;

        Vector3 movingForce = moveDirection * forceMultiplier;
        
        player.AddForce(movingForce);

        //player.position += moveDelta;
    }
}
