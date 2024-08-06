using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallPusher : MonoBehaviour
{
    // Start is called before the first frame update

    public Rigidbody BallRGB;
    public Vector3 directionforforce;
    public float sizeforForce;
    public bool justOnePush; 
    private bool pushed;
    private Vector3 currentVelocity;
    private Vector3 lastVelocity;
    private Vector3 currentAcceleration;
    private Vector3 lastAcceleration;
    [SerializeField] bool letrefereepush;
    void Start()
    {
        pushed = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void FixedUpdate()
    {
        if(!letrefereepush)
       {
      
      //Debug.Log("Force Direction : " + directionforforce);
       
       if(justOnePush)
       {
           if(pushed == false)
           {
              // Debug.Log("Push the Ball");
               BallRGB.AddForce(directionforforce*sizeforForce,ForceMode.Impulse);
               pushed= true;
           }
       }
       else
       {
           //Debug.Log("Push the Ball again");
           BallRGB.AddForce(directionforforce*sizeforForce,ForceMode.Impulse);
       }
       }
       //Debug.Log("Speed : " + BallRGB.velocity.magnitude.ToString("0.###"));
       //Debug.Log("Speed : " + BallRGB.velocity.ToString("0.###"));
       Debug.Log("Applying Impulse Force : " + (directionforforce*sizeforForce).ToString("0.###"));
       
       currentVelocity = BallRGB.velocity;
       Debug.Log("Current velocity: " + currentVelocity);


       currentAcceleration = (currentVelocity - lastVelocity) / Time.fixedDeltaTime;
       Debug.Log("Current Acceleration : " + currentAcceleration);


       lastAcceleration = currentAcceleration;
       Debug.Log("Last Acceleration : " + lastAcceleration);


       lastVelocity = currentVelocity;
       Debug.Log("Last velocity: " + lastVelocity);
    }
    public void HitBall(Vector3 forceDirection, float forceSize)
    {
        BallRGB.AddForce(forceDirection*forceSize,ForceMode.Impulse);
    }
}
