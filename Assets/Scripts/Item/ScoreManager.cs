using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text scoreText;
    public Text hightScoreText;

    public float scoreCount;
    public float hightScoreCount;

    public float pointsPerseconds;

    public bool scoreIncreasing;


    // Start is called before the first frame update
    void Start()
    {
        if(PlayerPrefs.GetFloat("HighScore") != null)
        {
            hightScoreCount = PlayerPrefs.GetFloat("HighScore");
        }
    }

    // Update is called once per frame
    void Update()
    {

        if (scoreIncreasing)
        {
            scoreCount += pointsPerseconds * Time.deltaTime;
        }

        if (scoreCount >= hightScoreCount)
        {
            hightScoreCount = scoreCount;
            PlayerPrefs.SetFloat("HighScore", hightScoreCount); 
        }

        scoreText.text = "Score: " + Mathf.Round(scoreCount);
        hightScoreText.text = "Hight score: " + Mathf.Round(hightScoreCount); 
    }

    public void AddScore(int pointsToAdd)
    {
        scoreCount += pointsToAdd;
    }
}
