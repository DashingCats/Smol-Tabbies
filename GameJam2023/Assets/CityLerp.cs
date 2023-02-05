using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CityLerp : MonoBehaviour
{
    //Nathan Woo's Lerp
    public Vector3 startPoint = new Vector3(0, 0, 0);
    public Vector3 endPoint = new Vector3(0, 0, 0); //Change this into a function parameter later


    private float deltaTime = 0.0f;
    public float lerpDuration = 3.0f; //Speed Modifier
    [SerializeField]
    private float interpolationParameter = 0.0f;

    //public bool isLerping = false; //Enables and Disables movement

    public bool EaseInEaseOut = false; //Choose if the LERP eases in and out
    public bool useEasingCurve = false; //True = Use the graph to change the easing

    //Just use curves and lerp duration, easier
    public bool lerpBack = false; //Potential implimentation for it to go back and forth

    [SerializeField]
    public AnimationCurve easingCurve; //Create a Curve Menu that controls the Easing for Lerp

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        LerpPosition();

        if (transform.position.x == endPoint.x) //Reset lerp to make infinite tiles
        {
            startPoint.x = 19.76f;
            endPoint.x = -19.8f;
            lerpDuration = 50;
            deltaTime = 0;
        }
    }


    private void LerpPosition()
    {


        deltaTime += Time.deltaTime; //Speed
        interpolationParameter = deltaTime / lerpDuration; //Calculate the interpolation parameter based on how fast



        if (EaseInEaseOut == false)
        {
            transform.position = Vector3.Lerp(startPoint, endPoint, interpolationParameter);
        }

        else
        {
            if (useEasingCurve)
            {
                transform.position = Vector3.Lerp(startPoint, endPoint, easingCurve.Evaluate(interpolationParameter));
            }
            else
            {
                transform.position = Vector3.Lerp(startPoint, endPoint, Mathf.SmoothStep(0, 1, interpolationParameter));
            }
        }

    }
}
