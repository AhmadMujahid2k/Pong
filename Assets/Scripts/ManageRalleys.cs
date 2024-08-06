using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageRalleys : MonoBehaviour
{
    [SerializeField] Vector3 centreofFrame;
    [SerializeField] GameObject ballPrefab;
    [SerializeField] GameObject currentBall;
    [SerializeField] KeepScore scorer;
    [SerializeField] float pushForceSize;
    [SerializeField] GameObject referee;
    private ManageMatch MM;
    private Vector3 pushDir;
    
    
    // Start is called before the first frame update
    void Start()
    {
        pushDir = Vector3.right;
        currentBall.GetComponent<BallPusher>().HitBall(pushDir,pushForceSize);
        MM = referee.GetComponent<ManageMatch>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void recieveAnnouncement(string wallName)
    {
       // Debug.Log(wallName + "has been hit by Ball");
        if(wallName == "leftWall")
        {
            scorer.incrementScoreP1();
            pushDir = Vector3.right;
        }
        else if(wallName == "rightWall")
        {
           scorer.incrementScoreP2();
           pushDir = Vector3.left;
        }
        RestartRalley();
         MM.forManageMatches();
    }
  public void RestartRalley()
  {
      Destroy(currentBall);
      currentBall = Instantiate(ballPrefab,centreofFrame,Quaternion.identity);
      currentBall.GetComponent<BallPusher>().HitBall(pushDir,pushForceSize);
  }
}