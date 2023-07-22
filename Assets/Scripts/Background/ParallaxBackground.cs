//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class ParallaxBackground : MonoBehaviour
//{
//    public GameObject camera;
//    public float parallaxEffect;
//    private float width, positionX;

//    void Start()
//    {
//        width = GetComponent<SpriteRenderer>().bounds.size.x;
//        positionX = transform.position.x;
//    }

//    void Update()
//    {
//        float parallaxDistance = camera.transform.position.x * parallaxEffect;
//        float remainingDistance = camera.transform.position.x * (1 - parallaxEffect);
//        transform.position = new Vector3(positionX + parallaxDistance, transform.position.y, transform.position.z);
//        if (remainingDistance > positionX + width)
//        {
//            positionX += width;
//        }
//    }
//}

//using UnityEngine;

//public class ParallaxBackground : MonoBehaviour
//{
//    public Camera mainCamera;
//    public float parallaxEffect;
//    private float width, startPosition;

//    void Start()
//    {
//        width = GetComponent<SpriteRenderer>().bounds.size.x;
//        startPosition = transform.position.x;
//    }

//    void Update()
//    {
//        float parallaxDistance = (mainCamera.transform.position.x - startPosition) * parallaxEffect;
//        float newPositionX = startPosition + parallaxDistance;
//        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);

//        // Check if the background needs to wrap
//        if (Mathf.Abs(parallaxDistance) >= width)
//        {
//            // If the camera moves more than the background's width, move it to the opposite side
//            startPosition = mainCamera.transform.position.x - (Mathf.Sign(parallaxDistance) * width);
//        }
//    }

//    // Function to reset the parallax background to its initial position
//    public void ResetBackground()
//    {
//        startPosition = mainCamera.transform.position.x;
//    }
//}




using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    public Camera mainCamera;
    public float parallaxEffect;
    private float width, startPosition;

    void Start()
    {
        width = GetComponent<SpriteRenderer>().bounds.size.x;
        startPosition = transform.position.x;
    }

    void Update()
    {
        float parallaxDistance = (mainCamera.transform.position.x - startPosition) * parallaxEffect;
        float newPositionX = startPosition + parallaxDistance;
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);

        // Check if the background needs wrap
        if (Mathf.Abs(parallaxDistance) >= width)
        {
            // If the camera moves more than the background's width, move it to the opposite side
            startPosition += Mathf.Sign(parallaxDistance) * width;
        }
    }

    // Function to reset the parallax background to its initial position
    public void ResetBackground()
    {
        startPosition = mainCamera.transform.position.x;
    }
}
