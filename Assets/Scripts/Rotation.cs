using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] float limitCWRotation,limitAWRotation, speedRotation , marginOfError;
    [SerializeField] KeyCode keyCWRotation , keyAWRotation;
    [SerializeField] Transform paddle; 
    private Vector3 currentPaddleRotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        currentPaddleRotation = paddle.rotation.eulerAngles;
       // Debug.Log("Paddle current rotation : " + paddle.rotation);
        if (Input.GetKey(keyCWRotation))
        {
            if(currentPaddleRotation.z == 0 || currentPaddleRotation.z >= (360+limitCWRotation))
            {
                currentPaddleRotation.z -= speedRotation;
                paddle.rotation = Quaternion.Euler(currentPaddleRotation);
            }
        }
        else if (Input.GetKey(keyAWRotation))
        {
             if(currentPaddleRotation.z <= limitAWRotation)
           {
                currentPaddleRotation.z += speedRotation;
                paddle.rotation = Quaternion.Euler(currentPaddleRotation);
           }
        }
        else
        {
            if((currentPaddleRotation.z - 0.0f) >= marginOfError 
            && currentPaddleRotation.z <= (limitAWRotation+1))
            {
                // RotationDriveMode back to 0 with CW
                currentPaddleRotation.z -= speedRotation;
                paddle.rotation = Quaternion.Euler(currentPaddleRotation);
            }
            else if((currentPaddleRotation.z <= 360 
            && currentPaddleRotation.z >= (360+limitCWRotation-1)))
            {
               // RotationDriveMode back to 0 with AW
                currentPaddleRotation.z += speedRotation;
                paddle.rotation = Quaternion.Euler(currentPaddleRotation);
            }
            else if(Mathf.Abs(currentPaddleRotation.z - 0.0f) <= marginOfError)
            {
                currentPaddleRotation.z = 0.0f;
                paddle.rotation = Quaternion.Euler(currentPaddleRotation);
            }
        }
    }
}