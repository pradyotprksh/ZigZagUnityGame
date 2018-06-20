using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class UiManager : MonoBehaviour {

    public static UiManager instance;
    public GameObject zigZagPanel;
    public GameObject gameOverPanel;
    public GameObject tapText;
    public Text score;
    public Text highScore1, highScore2;

	private void Awake()
	{
        if (instance == null) {
            instance = this;
        }
	}

	// Use this for initialization
	void Start () {
        highScore1.text = PlayerPrefs.GetInt("highScore").ToString();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void GameStart() {
        tapText.SetActive(false);
        zigZagPanel.GetComponent<Animator>().Play("panelUp");
    }

	public void Reset()
	{
        SceneManager.LoadScene(0);
	}

	public void GameOver() {
        score.text = PlayerPrefs.GetInt("score").ToString();
        highScore2.text = PlayerPrefs.GetInt("highScore").ToString();
        gameOverPanel.SetActive(true);
    }

}
