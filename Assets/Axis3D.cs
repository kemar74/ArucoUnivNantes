using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class NumericExtensions
{
    public static float ToRadians(float val)
    {
        return ((float)System.Math.PI / 180) * val;
    }
}


public class Axis3D : MonoBehaviour 
{
    public enum DIRECTION {X, Y, Z};
    public string label;
    public DIRECTION direction;

    public Mesh axisMesh;

    private GameObject axis;
    private TextMesh text;


    void Start()
    {
        axis = new GameObject();
        axis.transform.SetParent(this.transform);
        axis.AddComponent<MeshRenderer>();
        axis.AddComponent<MeshFilter>();
        MeshFilter meshfilter = axis.GetComponent<MeshFilter>();
        meshfilter.mesh = axisMesh;
        axis.SetActive(true);
        axis.transform.position = new Vector3(0, 0, 0);
        axis.transform.localScale = new Vector3(5, 5, 100);

        text = (TextMesh)(new GameObject()).AddComponent<TextMesh>();
        text.text = label;
        Quaternion text_rotation = new Quaternion();
        Quaternion rotation = new Quaternion();
        if(direction == DIRECTION.X) {
            rotation.eulerAngles = new Vector3(0, -90, 0);
            text_rotation.eulerAngles = new Vector3(0, -90, 0);
        }
        else if(direction == DIRECTION.Y) {
            rotation.eulerAngles = new Vector3(180, 0, 0);
            text_rotation.eulerAngles = new Vector3(180, 0, -90);
        }
        else if(direction == DIRECTION.Z) {
            rotation.eulerAngles = new Vector3(90, 0, 0);
            text_rotation.eulerAngles = new Vector3(0, 180, 0);
            text.transform.Translate(new Vector3(2 * text.GetComponent<Renderer>().bounds.extents.x, 0, 0));
        }
        this.transform.rotation = rotation;
        text.transform.SetParent(this.transform);
        text.transform.rotation = text_rotation;

    }

    void Update()
    {

    }
}