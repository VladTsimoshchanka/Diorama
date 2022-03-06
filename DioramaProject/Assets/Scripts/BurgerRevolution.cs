using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerRevolution : MonoBehaviour
{
    [Range(0, 360)]
    public float maximumAngleForEvent = 30f;
    public Animator animation;
    // Start is called before the first frame update
    void Start()
    {
        animation = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        var cameraForward = Camera.main.transform.forward;
        var vectorToObject = transform.position - Camera.main.transform.position;

        // Check if the angle between the camera and object is within the hover range
        var angleFromCameraToObject = Vector3.Angle(cameraForward, vectorToObject);
        if (angleFromCameraToObject <= maximumAngleForEvent)
        {
            animation.speed = angleFromCameraToObject / maximumAngleForEvent;
            
        }
    }
}
