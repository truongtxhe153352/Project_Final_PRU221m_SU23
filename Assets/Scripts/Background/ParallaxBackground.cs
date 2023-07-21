using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxBackground : MonoBehaviour
{
    public GameObject camera;
    public float parallaxEffect;
    private float width, positionX;

     void Start()
    {
        width = GetComponent<SpriteRenderer>().bounds.size.x;
        positionX = transform.position.x;
    }

    void Update()
    {
        float parallaxDistance = camera.transform.position.x * parallaxEffect;
        float remainingDistance = camera.transform.position.x * (1 - parallaxEffect);
        transform.position = new Vector3(positionX + parallaxDistance, transform.position.y, transform.position.z);
        if (remainingDistance > positionX + width ) {
            positionX += width;
        }
    }


    //public Transform mainCamera;
    //public Transform middleBG;
    //public Transform sideBG;

    //public float length = 38.4f;

    //void Update()
    //{
    //    if(mainCamera.position.x > middleBG.position.x)
    //    {
    //        sideBG.position = middleBG.position + Vector3.right * length ;
    //    }

    //    if (mainCamera.position.x < middleBG.position.x)
    //    {
    //        sideBG.position = middleBG.position + Vector3.left * length;
    //    }

    //    if (mainCamera.position.x > sideBG.position.x || mainCamera.position.x < sideBG.position.x)
    //    {
    //        Transform transform = middleBG;
    //        middleBG = sideBG;
    //        sideBG = transform;
    //    }
    //}
}
