using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirbScript : MonoBehaviour
{
    // Declaring references and variables
    public Rigidbody2D myRigidbody2D;
    public float flapStrength = 10;
    public float initialBirdRotationAngle;
    public float returnBirdRotationAngle;  
    public float birdRotationSmoothness;
    public bool didBirdFlap;
    public bool didBirdRotate;
    float birdRotationVelocity;
    public void IncreaseBirdAOA()
    {
        float angle = Mathf.SmoothDampAngle(transform.eulerAngles.z, initialBirdRotationAngle, ref birdRotationVelocity, birdRotationSmoothness);

        transform.rotation = Quaternion.Euler(0, 0, angle);

        didBirdRotate = true;
    }
    public void DecreaseBirdAOA()
    {
        float returnAngle = Mathf.SmoothDampAngle(transform.eulerAngles.z, returnBirdRotationAngle, ref birdRotationVelocity, birdRotationSmoothness);

        transform.rotation = Quaternion.Euler(0, 0, returnAngle);
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        // bird flies upward after pressing 'spacebar'      
        if (Input.GetKeyDown(KeyCode.Space))
        {
            myRigidbody2D.velocity = Vector2.up * flapStrength;
            didBirdFlap = true;
        }
    }
    private void FixedUpdate()
    {
        if(didBirdFlap == true)
        {
            // this method is under construction. after testing functionality here, this will be initialized every time the bird flaps.
            IncreaseBirdAOA();
                     
        }
    }
    
}