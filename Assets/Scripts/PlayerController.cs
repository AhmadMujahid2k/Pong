using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float paddleSpeed;
    public Transform paddle;
    public float topMax,bottomMax;
    public KeyCode upKey,downKey;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 paddlePos = paddle.position;
        if(Input.GetKey(upKey) && paddlePos.y<topMax)
        {
            Debug.Log("Moving Up.");
            paddlePos.y += paddleSpeed;
        }

        if(Input.GetKey(downKey) && paddlePos.y>bottomMax)
        {
            Debug.Log("Moving Down.");
            paddlePos.y -= paddleSpeed;
        }
        paddle.position = paddlePos;
    }
}