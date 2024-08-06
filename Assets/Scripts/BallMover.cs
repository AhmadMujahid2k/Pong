using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMover : MonoBehaviour
{

    public Rigidbody BallRGB;
    public Vector3 direction;
    public float sizeOfForce; 
    public Vector3 force;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

   private void FixedUpdate()
    {
       applyforceInDirection();
    }

    private void applyforceInDirection()
    {
        Vector3 force = (direction * sizeOfForce);
        Debug.Log("Apply force of : " + force.ToString("0.###"));
        BallRGB.AddForce(force,ForceMode.Impulse);
    }
}