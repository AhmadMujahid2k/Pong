using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnounceBallHit : MonoBehaviour
{

    private string wallName;
    [SerializeField] GameObject referee;
    [SerializeField] string  expectedBallTag;
    private ManageRalleys RM;

    


    // Start is called before the first frame update
    void Start()
    {
        wallName = this.gameObject.name;
        RM = referee.GetComponent<ManageRalleys>();
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("My name is " + wallName);
    }

    private void OnCollisionEnter(Collision other)
    {
        //Debug.Log(other.transform.parent.gameObject.name + "has hit me");
        if(null!=other.transform.parent && (other.transform.parent.gameObject.CompareTag(expectedBallTag)))
        {
            RM.recieveAnnouncement(wallName);
        }
    }
}