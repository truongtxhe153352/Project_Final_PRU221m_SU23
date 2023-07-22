using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickPupPoints : MonoBehaviour
{
    public int scoreToGive;

    private ScoreManager scoreManager;

    private AudioSource coinSoud;

    // Start is called before the first frame update
    void Start()
    {
        scoreManager = FindObjectOfType<ScoreManager>();

        coinSoud = GameObject.Find("Coin").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            scoreManager.AddScore(scoreToGive);
            gameObject.SetActive(false);

            if (coinSoud.isPlaying)
            {
                coinSoud.Stop();
                coinSoud.Play();
            } else
            {
                coinSoud.Play();
            }

        }
    }
}
