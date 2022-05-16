using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float speed = 5f; 

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame (60 frames in s) 
    void Update()
    {
        // grab user input 
        float h = Input.GetAxis("Horizontal"); // get input for A D right left key 
        float v = Input.GetAxis("Vertical");   // get input for W S up down key 

        Vector2 pos = transform.position;

        // x pos 
        pos.x += h * speed * Time.deltaTime; 
        // y pos
        pos.y += v * speed * Time.deltaTime;

        // transform pos using x/y axis 
        transform.position = pos;           //--smoothing out the movement 
    }
} //--end of class 
