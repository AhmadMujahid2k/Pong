using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class monitorState : MonoBehaviour
{

[SerializeField] Text txtFps,txtphysicsLOOP;
float FPS;
int counter;
    // Start is called before the first frame update
    void Start()
    {
        FPS = 0.0f;
        counter =0;
    }

    // Update is called once per frame
    void Update()
    {
        FPS = 1/Time.deltaTime;
        txtFps.text = "FPS = " + FPS.ToString("0.###");
        txtphysicsLOOP.text = "Physics Loop per Frame = " + counter;
        counter =0;

    }

    private void FixedUpdate() {
        counter++;
    }
}
