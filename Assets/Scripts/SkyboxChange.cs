using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxChange : MonoBehaviour
{
    public Material[] skybox;
    Material skyboxMaterial;


    void Start()
    {
        
        skyboxMaterial = skybox[Random.Range(0, skybox.Length)];
        RenderSettings.skybox = skyboxMaterial;

    }

    
    void Update()
    {
        
    }



    

}
