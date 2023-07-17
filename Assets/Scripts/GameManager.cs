using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform platformGenerator;
    private Vector3 platformStartPoint;

    public PlayerController playerController;
    private Vector3 playerStartPoint;

    private GroundBehaviour[] platformList;

    private ScoreManager theScoreManager;

    public DeathMenu theDeathMenu;


    // Start is called before the first frame update
    void Start()
    {
        platformStartPoint = platformGenerator.position;
        playerStartPoint = playerController.transform.position;

        theScoreManager = FindObjectOfType<ScoreManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void restartGame()
    {
        theScoreManager.scoreIncreasing = false;
        playerController.gameObject.SetActive(false);

        theDeathMenu.gameObject.SetActive(true);

        // StartCoroutine ("RestartGameCo");
    }

    public void Reset()
    {
        theDeathMenu.gameObject.SetActive(false);
        platformList = FindObjectsOfType<GroundBehaviour>();
        for (int i = 0; i < platformList.Length; i++)
        {
            platformList[i].gameObject.SetActive(false);
        } 

        playerController.transform.position = playerStartPoint;
        platformGenerator.position = platformStartPoint;
        playerController.gameObject.SetActive(true);

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;
    }

    //public IEnumerator RestartGameCo()
    //{
    //    theScoreManager.scoreIncreasing = false;
    //    playerController.gameObject.SetActive(false);
    //    yield return new WaitForSeconds(0.5f);
    //    platformList = FindObjectsOfType<GroundBehaviour>();
    //    for (int i = 0; i < platformList.Length; i++)
    //    {
    //        platformList[i].gameObject.SetActive(false);
    //    }

    //    playerController.transform.position = playerStartPoint;
    //    platformGenerator.position = platformStartPoint;
    //    playerController.gameObject.SetActive(true);

    //    theScoreManager.scoreCount = 0;
    //    theScoreManager.scoreIncreasing = true;
    //}
}
