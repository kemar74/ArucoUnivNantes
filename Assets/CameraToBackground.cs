using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArucoUnity.Cameras;

public class CameraToBackground : MonoBehaviour
{
    public Renderer gui;
    public Camera backCam;

    private Material renderTexture;
    private ArucoWebcam cam;
    // Start is called before the first frame update
    void Start()
    {
        cam = gameObject.GetComponent<ArucoWebcam>();
        WebCamTexture tex = new WebCamTexture(WebCamTexture.devices[0].name, Screen.width, Screen.height, 10);
        tex.Play();
        if(gui) {
            gui.material.mainTexture = tex;
        }
    }

    // Update is called once per frame
    void Update()
    {
        //print(backCam.targetTexture);
    }
}
