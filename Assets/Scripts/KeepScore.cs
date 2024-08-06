using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class KeepScore : MonoBehaviour
{
    public int scoreP1,scoreP2,matchP1,matchP2;
    [SerializeField] Text txtP1,txtP2,txtmatchP1,txtmatchP2,txtSuddenDeath;
    // Start is called before the first frame update
    void Start()
    {
        scoreP1 = 0;
        scoreP2 = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (this.matchP1 == 2 || this.matchP2 == 2)
        {
            SceneManager.LoadSceneAsync(1);
        }
    }
    

    public void incrementScoreP1()
    {
        scoreP1++;
        updateScores();
    }
    public void incrementScoreP2()
    {
        scoreP2++;
        updateScores();
    }
    public void incMatchP1()
    {
        scoreP1 = 0;
        scoreP2 = 0;
        matchP1++;
        updateScores();
        updateMatch();
    }
    public void incMatchP2()
    {
        scoreP1 = 0;
        scoreP2 = 0;
        matchP2++;
        updateScores();
        updateMatch();
    }
    public void deuce()
    {
        scoreP1 = 7;
        scoreP2 = 7;
        updateScores();
    }
    public void suddenDeath()
    {
        txtSuddenDeath.text = "SUDDEN DEATH";
        scoreP1 = 10;
        scoreP2 = 10;
        updateScores();
    }
    public void removeSuddenDeathMessage()
    {
        txtSuddenDeath.text = " ";
    }
    private void updateScores()
    {
        txtP1.text = "              Score = " + scoreP1.ToString();
        txtP2.text = "Score = " + scoreP2.ToString();
    }
    private void updateMatch()
    {
        txtmatchP1.text = "              Match = " + matchP1.ToString();
        txtmatchP2.text = "Match = " + matchP2.ToString();
    }
}