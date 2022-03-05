using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WatermelonPageant : MonoBehaviour
{
    public Material[] colors;
    Color c;
    
    int i;
    // Start is called before the first frame update
    
   
    void Start()
    {
        colors = GetComponent<Renderer>().materials;
       
        
    }

    // Update is called once per frame
    void Update()
    {
       
        
    }
    public float changeColor(float value)
    {
        return value / 360.0f;
    }
}
