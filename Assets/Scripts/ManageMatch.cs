using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ManageMatch : MonoBehaviour
{
    [SerializeField] KeepScore scorer2;
    int counterduece;
    // Start is called before the first frame update
    void Start()
    {
        counterduece = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void forManageMatches()
    {
        if(scorer2.scoreP2 <= 8 && scorer2.scoreP1 == 10)
        {
            scorer2.incMatchP1();
        }
        else if(scorer2.scoreP2 == 10 && scorer2.scoreP1 <= 8)
        {
            scorer2.incMatchP2();
        }
        else if(scorer2.scoreP2 == 9 && scorer2.scoreP1 == 9)
        {
            scorer2.deuce();
            counterduece++;
        }
        else if(scorer2.scoreP2 == 11 && scorer2.scoreP1 == 10)
        {
            scorer2.incMatchP2();
            scorer2.removeSuddenDeathMessage();
        }
        else if(scorer2.scoreP2 == 10 && scorer2.scoreP1 == 11)
        {
            scorer2.incMatchP1();
            scorer2.removeSuddenDeathMessage();
        }
        if(counterduece == 3)
        {
            scorer2.suddenDeath();
            counterduece = 0;
        }
    }
}
