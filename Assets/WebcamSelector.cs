using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ArucoUnity.Cameras;

public class WebcamSelector : MonoBehaviour
{
    public bool prefer_back_cam;
    // Start is called before the first frame update
    void Start()
    {
        ArucoWebcam cam = gameObject.GetComponent<ArucoWebcam>();

        WebCamDevice[] devices = WebCamTexture.devices;
        List<int> backIds = new List<int>();
        List<int> frontIds = new List<int>();
        for(int i = 0; i < devices.Length; i++) {
            WebCamTexture c = new WebCamTexture(devices[i].name);
            c.Play();
            if(c.isPlaying) { // Checks if the webcam is working
                c.Stop();
                if(devices[i].isFrontFacing) {
                    frontIds.Add(i);
                } else {
                    backIds.Add(i);
                }
            }
        }
        
        int camId = -1;
        
        Text txt = GameObject.Find("Text").GetComponent<Text>();
        txt.text = "";
        for(int i = 0; i < backIds.Count; i++) {
            camId = backIds[i];
            txt.text += camId.ToString() + " : " + devices[camId].name + "\n";
        }
        for(int i = 0; i < frontIds.Count; i++) {
            camId = frontIds[i];
            txt.text += camId.ToString() + " : " + devices[camId].name + "\n";
        }
        
        cam.WebcamId = camId;
        try{
            cam.StopController();
        } catch {
            cam.ConfigureController();
            cam.StartController();
            txt.text = (cam.isActiveAndEnabled ? "Cam enable" : "Cam unavailable");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
