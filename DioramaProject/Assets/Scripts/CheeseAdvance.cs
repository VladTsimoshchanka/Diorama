using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseAdvance : MonoBehaviour
{
    // Start is called before the first frame update

    [Range(0, 360)]
    public float maximumAngleForEvent = 20f;
    public GameObject cheese;

    void Start()
    {
        cheese = GameObject.Find("Cheese");
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
            cheese.transform.position = new Vector3(transform.position.x, transform.position.y, -30 + maximumAngleForEvent - angleFromCameraToObject);
        }
    }
}
