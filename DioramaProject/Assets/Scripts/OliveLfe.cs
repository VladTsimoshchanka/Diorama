using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OliveLfe : MonoBehaviour
{
    public GameObject olive;
    public float speed = 5f;
    // Start is called before the first frame update
    void Start()
    {
        olive = GameObject.Find("CenterOlive");
    }

    // Update is called once per frame
    void Update()
    {

        transform.RotateAround(olive.transform.position, Vector3.up, speed * Time.deltaTime);
        
    }
}
