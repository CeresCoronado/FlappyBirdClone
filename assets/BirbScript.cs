using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbScript : MonoBehaviour
{
    // Rigidbody2D is a physics object attached to the Bird that carries out this script
    public Rigidbody2D myRigidbody2D;
    
    // Variables that can be changed within Unity that effects BirbLift()
    public float flapStrength = 10;
    
    // Variables that can be changed within Unity that effects BirbTiltUp() and BirbTiltDown()
    public float initialBirdRotationAngle = 1;
    public float returnBirdRotationAngle = 1;
       
    // BirbLift() Makes the birb go up
    public void BirbLift()
    {
        myRigidbody2D.velocity = Vector2.up * flapStrength;
    }
    // BirbTiltUp() Makes the birb tilt its beak facing up
    public void BirbTiltUp()
    {
        float birdRotationVelocityUp = 10;
        float birdRotationSmoothness = 0;
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.z, initialBirdRotationAngle, ref birdRotationVelocityUp, birdRotationSmoothness);

        transform.rotation = Quaternion.Euler(0, 0, angle);
    }
    // BirbTiltDown() Makes the birb til its beak facing down
    public void BirbTiltDown()
    {
        float birdRotationVelocityDown = 10;
        float birdRotationSmoothness = 0;
        float returnAngle = Mathf.SmoothDampAngle(transform.eulerAngles.z, returnBirdRotationAngle, ref birdRotationVelocityDown, birdRotationSmoothness);

        transform.rotation = Quaternion.Euler(0, 0, returnAngle);
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
            BirbLift();
        }
         
    }
    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            BirbTiltUp();
        }
        else
        {
            BirbTiltUp();
        }
    }
}
