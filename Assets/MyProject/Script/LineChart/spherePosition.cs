using UnityEngine;
using System.Collections;

public class spherePosition : MonoBehaviour {

    public Transform[] Sphere;
    float[,] xyValue = new float[6, 2] { {10f, 70f }, { 205f, 60f }, { 30f,50f }, { 40f, 40f } , {50f ,30f}, { 60f,20f} };

    float x = -3f;
    float y = 0f;

    float xlengh = 0.06f;
    float ylengh = 0.04f;

    // Use this for initialization
    void Start () {
        for (int i = 0; i < Sphere.Length; i++)
        {
            Sphere[i].position = new Vector3((x + (xyValue[i, 0] * xlengh)), (y + (xyValue[i,1]*ylengh)), Sphere[i].position.z);
            
        }
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
