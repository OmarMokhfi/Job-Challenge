using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class menuController : MonoBehaviour
{
    private Text score;
    void Start()
    {
        score = GameObject.FindGameObjectWithTag("score").GetComponent<Text>();
        score.text = PlayerPrefs.GetInt("HighScore").ToString();
    }

    public void nextLevel(){
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
