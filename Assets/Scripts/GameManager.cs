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

    // Start is called before the first frame update
    void Start()
    {
        _ = platformStartPoint - platformGenerator.position;
        playerStartPoint = playerController.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void restartGame()
    {
        StartCoroutine ( "RestartGameCo");
    }

    public IEnumerator RestartGameCo()
    {
        playerController.gameObject.SetActive (false);
        yield return new WaitForSeconds(0.5f);
        platformList = FindObjectsOfType<GroundBehaviour>();
        for(int i = 0; i < platformList.Length; i++)
        {
            platformList[i].gameObject.SetActive (false);
        }

        playerController.transform.position = playerStartPoint;
        platformGenerator.position = platformStartPoint;
        playerController.gameObject.SetActive (true);
    }
}
