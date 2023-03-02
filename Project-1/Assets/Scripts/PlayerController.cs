using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float speed = 20;
    [SerializeField] private float turnSpeed = 0.5f;
    private float horizontalInput;
    private float forwardInput;    



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        forwardInput = Input.GetAxis( "Vertical" );
        horizontalInput = Input.GetAxis( "Horizontal" );
        // we will move vhicale forward
        transform.Translate(Vector3.forward * Time.deltaTime * speed * forwardInput);
        // turns vhicale
       // transform.Translate( Vector3.right * Time.deltaTime * turnSpeed * horizontalInput );
       //Rotates vehical round the y axis
        transform.Rotate(Vector3.up* Time.deltaTime * turnSpeed * horizontalInput );

        
    }
}
