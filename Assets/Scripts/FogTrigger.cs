﻿using UnityEngine;
using System.Collections;

public class FogTrigger : MonoBehaviour
{
    public Material NightSky;
    void OnTriggerEnter(Collider other)
    {
        
        RenderSettings.fog = !RenderSettings.fog;
        RenderSettings.skybox = NightSky;
        gameObject.SetActive(false);
        GameController.Instance.DirectionalLight.SetActive(false);
    }

   

}
