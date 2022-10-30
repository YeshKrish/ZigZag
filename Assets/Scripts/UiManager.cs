using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

    public static UiManager instance; 

    public GameObject FunBallPanel;
    public GameObject gameOverPanel;
    public GameObject taptext;
    public Text Score;
    public Text HighScore1;
    public Text HighScore2;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    // Use this for initialization
    void Start() {
        HighScore1.text = "HighScore: " + PlayerPrefs.GetInt("highscore").ToString();
    }

    public void GameStart()
    {
       
        taptext.SetActive(false);
        FunBallPanel.GetComponent<Animator>().Play("PanelUp");
    }

    public void GAMEOVER()
    {
        Score.text = PlayerPrefs.GetInt("score").ToString();
        HighScore2.text = PlayerPrefs.GetInt("highscore").ToString();
        gameOverPanel.SetActive(true);

    }

    public void Reset()
    {
        SceneManager.LoadScene(0);
    }

	// Update is called once per frame
	void Update () {
		
	}
}
