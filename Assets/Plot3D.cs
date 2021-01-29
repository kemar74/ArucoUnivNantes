using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Plot3D : MonoBehaviour
{
    public Mesh meshAxis;
    // Start is called before the first frame update
    void Start()
    {
        List<Vector3> points = new List<Vector3>();

        for(int x = -1; x < 2; x++) {
            for(int y = -1; y < 2; y++) {
                points.Add(new Vector3(x, y, (float)(Math.Sin(x))));
            }
        }



        for(int i = 0; i < points.Count; i++){
            //print(points[i].x + "," + points[i].y);
            GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            sphere.transform.position = new Vector3(points[i].x, points[i].z, points[i].y);
            sphere.transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            // sphere.parent = this;
        }

        GameObject goXaxis = new GameObject();
        Axis3D Xaxis = (Axis3D)goXaxis.AddComponent<Axis3D>();
        Xaxis.direction = Axis3D.DIRECTION.X;
        Xaxis.label = "X-axis";
        GameObject goYaxis = new GameObject();
        Axis3D Yaxis = (Axis3D)goYaxis.AddComponent<Axis3D>();
        Yaxis.direction = Axis3D.DIRECTION.Y;
        Yaxis.label = "Y-axis";
        GameObject goZaxis = new GameObject();
        Axis3D Zaxis = (Axis3D)goZaxis.AddComponent<Axis3D>();
        Zaxis.direction = Axis3D.DIRECTION.Z;
        Zaxis.label = "Z-axis";

        Xaxis.axisMesh = meshAxis;
        Yaxis.axisMesh = meshAxis;
        Zaxis.axisMesh = meshAxis;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
