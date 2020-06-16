using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scoreHandler : MonoBehaviour
{
    private int score;
    [SerializeField] private int scoreRate;
    private Text value;
    public GameObject gameOverPanel;
    private GameObject player;
    void Start()
    {
        score = 2;
        scoreRate = 2;
        value = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
        value.text = score.ToString();
        player = GameObject.FindGameObjectWithTag("Player");
    }

    public void addScore(){
        score += scoreRate;
        value.text = score.ToString();
        if(score > PlayerPrefs.GetInt("HighScore")){
            PlayerPrefs.SetInt("HighScore", score);
        }
    }

    public void substractScore(){
        score -= scoreRate;
        value.text = score.ToString();
        if(score <= 0){
            endGame();
        }
    }

    void endGame(){
        Destroy(player);
        gameOverPanel.SetActive(true);
    }
}
