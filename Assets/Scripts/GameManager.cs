//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class GameManager : MonoBehaviour
//{
//    public Transform platformGenerator;
//    private Vector3 platformStartPoint;

//    public PlayerController playerController;
//    private Vector3 playerStartPoint;

//    private GroundBehaviour[] platformList;

//    private ScoreManager theScoreManager;

//    public DeathMenu theDeathMenu;

//    // Reference to the EnemyGenerate script
//    private EnemyGenerate enemyGenerator;
//    //private EnemyFlyBlack enemyFlyBlack;

//    public bool isPlayerAlive = true;


//    // Start is called before the first frame update
//    void Start()
//    {
//        platformStartPoint = platformGenerator.position;
//        playerStartPoint = playerController.transform.position;

//        theScoreManager = FindObjectOfType<ScoreManager>();

//        // add enemy
//        enemyGenerator = FindObjectOfType<EnemyGenerate>(); // Assign the reference to the EnemyGenerate script
//       // enemyFlyBlack = FindObjectOfType<EnemyFlyBlack>(); // Assign the reference to the EnemyGenerate script

//    }

//    // Update is called once per frame
//    void Update()
//    {

//    }

//    public void restartGame()
//    {
//        theScoreManager.scoreIncreasing = false;
//        playerController.gameObject.SetActive(false);

//        // Gán giá trị true cho biến isAlive trong script PlayerController
//        //playerController.SetAliveStatus(true);

//        theDeathMenu.gameObject.SetActive(true);

//        // StartCoroutine ("RestartGameCo");

//        isPlayerAlive = false;
//    }

//    public void Reset()
//    {
//        theDeathMenu.gameObject.SetActive(false);
//        platformList = FindObjectsOfType<GroundBehaviour>();
//        for (int i = 0; i < platformList.Length; i++)
//        {
//            platformList[i].gameObject.SetActive(false);
//        } 

//        playerController.transform.position = platformStartPoint;//playerStartPoint
//        platformGenerator.position = playerStartPoint;
//        playerController.gameObject.SetActive(true);

//        theScoreManager.scoreCount = 0;
//        theScoreManager.scoreIncreasing = true;

//        // sống chết
//        isPlayerAlive = true;

//    }
//}


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

    private EnemyGenerate enemyGenerator;
    private EnemyFlyBlack enemyFlyBlack;

    public bool isPlayerAlive = true;

    void Start()
    {
        platformStartPoint = platformGenerator.position;
        playerStartPoint = playerController.transform.position;

        theScoreManager = FindObjectOfType<ScoreManager>();

        // Get the reference to the EnemyGenerate script.
        enemyGenerator = FindObjectOfType<EnemyGenerate>();
        enemyFlyBlack = FindObjectOfType<EnemyFlyBlack>();
    }

    public void restartGame()
    {
        theScoreManager.scoreIncreasing = false;
        playerController.gameObject.SetActive(false);

        theDeathMenu.gameObject.SetActive(true);

        isPlayerAlive = false;
    }

    public void Reset()
    {
        theDeathMenu.gameObject.SetActive(false);
        platformList = FindObjectsOfType<GroundBehaviour>();
        for (int i = 0; i < platformList.Length; i++)
        {
            platformList[i].gameObject.SetActive(false);
        }

        playerController.transform.position = platformStartPoint;
        platformGenerator.position = playerStartPoint;
        playerController.gameObject.SetActive(true);

        theScoreManager.scoreCount = 0;
        theScoreManager.scoreIncreasing = true;

        isPlayerAlive = true;

        // Reset the enemy generation script.
        enemyGenerator.ResetEnemyGeneration();
        enemyFlyBlack.ResetEnemyGeneration();
    }
}
