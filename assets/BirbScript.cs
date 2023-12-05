using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class BirbScript : MonoBehaviour
{
    // Rigidbody2D is a physics object attached to the Bird that carries out this script
    public Rigidbody2D myRigidbody;

    // Variables that can be changed within Unity that effects BirbLift()
    private float flapStrength = 10;

    // Variables that can be changed within Unity that effects BribTiltUp()
    private float rotationSpeed = 5;

    private bool willLift = false;
        
    // BirbLift() Makes the birb go up
    private void BirbFlap()
    {
        myRigidbody.velocity = Vector2.up * flapStrength;
    }
    // BirbTiltUp() Makes the birb tilt its beak facing up
    private void BirbTiltUp()
    {
        transform.Rotate(Vector3.forward, rotationSpeed);
    }
    // BirbTiltDown() Makes the birb til its beak facing down
    private void BirbTiltDown()
    {
    
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            willLift = true;

        }
    }
    private void FixedUpdate()
    {
        if (willLift)
        {
            BirbFlap();
            willLift=false;

        }
    }
}
