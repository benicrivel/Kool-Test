using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hex : MonoBehaviour
{
    bool rotating = false;
    public float smoothTime; //rotate over this time

    //Arrays for Spawn and Collision
    public Transform[] SpawnPoints;
    public Transform[] CollisionPoints;

    public void RotateNow()
    {
        if (!rotating)
        {
            rotating = true;
            StartCoroutine(RotateOverTime(transform.localEulerAngles.z, transform.localEulerAngles.z + 60, smoothTime));
        }        
    }
    
    IEnumerator RotateOverTime(float currentRotation, float desiredRotation, float overTime)
    {
        float i = 0.0f;
        while (i <= 1)
        {
            //Smooth animation
            transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, Mathf.Lerp(currentRotation, desiredRotation, i));
            i += Time.deltaTime / overTime;
            yield return null;
        }        
        //Corrects Z value
        float a = transform.localEulerAngles.z;
        if(a >= 25 && a <= 35)
        {
            a = 30;
        }
        else if (a >= 85 && a <= 95)
        {
            a = 90;
        }
        else if (a >= 145 && a <= 155)
        {
            a = 150;
        }
        else if (a >= 205 && a <= 215)
        {
            a = 210;
        }
        else if (a >= 265 && a <= 275)
        {
            a = 270;
        }
        else if (a >= 325 && a <= 335)
        {
            a = 330;
        }

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x, transform.localEulerAngles.y, a);
        rotating = false;
        yield return new WaitForSeconds(0.5f);
    }
}
