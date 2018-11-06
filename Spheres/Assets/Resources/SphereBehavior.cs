using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehavior : MonoBehaviour {

    Color lerpedColor = Color.white;
    Color newColor; // Object color
    float speed; //Movement speed
    float radius; //Spiral motion radius
    float angle;
    float colorChangeTimer; //Current color value 
    float colorChangeThreshold; //Time mark, which reverses the color saturation change direction
    bool colorChangePositiveDirection; //color saturation change direction
    Vector3 originalPosition;

    
    void Start()
    {
        originalPosition = transform.position;
        speed = Random.Range(0.01f, 0.5f);
        radius = Random.Range(1.0f, 50.0f);
        colorChangeThreshold = Random.Range(1.0f, 4.0f);
        colorChangeTimer = colorChangeThreshold;
        colorChangePositiveDirection = true;
    }


    void Update()
    {
        //Move objects in a spiral motion around the initial postion
        angle += speed * Time.deltaTime;
        var offset = new Vector3(Mathf.Sin(angle), Mathf.Cos(angle), Mathf.Tan(angle)) * radius;
        transform.position = originalPosition + offset;

        // Changes color direction when timer reaches threshold
        colorChangeTimer += Time.deltaTime;

        if (colorChangeTimer >= colorChangeThreshold && colorChangePositiveDirection == true)
        {
            colorChangeTimer = 0;
            colorChangePositiveDirection = false;
        }

        if (colorChangeTimer >= colorChangeThreshold && colorChangePositiveDirection == false)
        {
            newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            colorChangeTimer = 0;
            colorChangePositiveDirection = true;
        }

        //Color linear interpolation. Gradually changes from white to newColor and then backwards. 
        if (colorChangePositiveDirection == true)
        {
            lerpedColor = Color.Lerp(Color.white, newColor, colorChangeTimer / colorChangeThreshold);
        }
        else
        {
            lerpedColor = Color.Lerp(newColor, Color.white, colorChangeTimer / colorChangeThreshold);
        }

        //Updates color
        Renderer rend = GetComponent<Renderer>();
        rend.material.color = lerpedColor;
    }
    
}

