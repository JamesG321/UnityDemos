
using UnityEngine;
using System.Collections;

public class SetSunlight : MonoBehaviour
{
    //light source acting as the sun, in example is directional
    public Light sun;
    //set speed of the full day
    public float secondsInFullDay = 120f;
    //current time of day, 0 == midnight, 1 == midnight, 0.5 == noon
    [Range(0, 1)]
    public float currentTimeOfDay = 0;
    
    [HideInInspector]
    public float timeMultiplier = 1f;

    float sunInitialIntensity;

    void Start()
    {
        sunInitialIntensity = sun.intensity;
    }

    void Update()
    {
        UpdateSun();

        currentTimeOfDay += (Time.deltaTime / secondsInFullDay) * timeMultiplier;

        if (currentTimeOfDay >= 1)
        {
            currentTimeOfDay = 0;
        }
    }

    void UpdateSun()
    {
        //update rotation of sun according to time of day
        sun.transform.localRotation = Quaternion.Euler((currentTimeOfDay * 360f) - 90, 170, 0);

        //default intensity, where sun is constant 1 during the normal day
        float intensityMultiplier = 1;
        // currentTimeOfDay is night
        if (currentTimeOfDay <= 0.23f || currentTimeOfDay >= 0.75f)
        {
            intensityMultiplier = 0;
        }
        // dawn, sun rises and increases intensity
        else if (currentTimeOfDay <= 0.25f)
        {
            intensityMultiplier = Mathf.Clamp01((currentTimeOfDay - 0.23f) * (1 / 0.02f));
        }
        // dusk, sun falls and decreases intensity 
        else if (currentTimeOfDay >= 0.73f)
        {
            intensityMultiplier = Mathf.Clamp01(1 - ((currentTimeOfDay - 0.73f) * (1 / 0.02f)));
        }

        //update intensity
        sun.intensity = sunInitialIntensity * intensityMultiplier;
    }
}