    using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

    public static ScoreManager instance;
    public int Score;
    public int HighScore;

    void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
    }


	// Use this for initialization
	void Start () {
        Score = 0;
        PlayerPrefs.SetInt("score", Score);
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void incrementScore()
    {
        Score += 1;
    }

    public void StartScore()
    {
        InvokeRepeating("incrementScore", 0.1f, 0.5f);
    }

    public void StopScore()
    {
        CancelInvoke("incrementScore");
        PlayerPrefs.SetInt("score",Score);

        if (PlayerPrefs.HasKey("highscore"))
        {
            if (Score > PlayerPrefs.GetInt("highscore"))
            {
                PlayerPrefs.SetInt("highscore", Score);
            }
                 
        }
        else
        {
            PlayerPrefs.SetInt("highscore", Score);
        }
    }
}

