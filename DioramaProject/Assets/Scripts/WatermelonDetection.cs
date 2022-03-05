using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatermelonDetection : MonoBehaviour
{
    [Range(0, 360)]
    public float maximumAngleForEvent = 30f;
    // Start is called before the first frame update
    public Light light;
    Color c;
    void Start()
    {
        light = GameObject.Find("WatermelonSpotlight").GetComponent<Light>();
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
            light.color = Random.ColorHSV(0f, 1f, 1f, 1f, 1f, 1f, 1f, 1f);
        }
        /*(else
        {
            

           

                foreach (Material m in originalColors)
                {
                //Debug.Log("ee");

                    GetComponent<Renderer>().materials[i] = m;
                    colors[i] = m;
                    i++;
                    if (i >= 5)
                    {
                        i = 0;
                    }
                    
                }
           
        }*/
    }
}
