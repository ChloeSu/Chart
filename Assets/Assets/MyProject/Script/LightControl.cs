using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightControl : MonoBehaviour {
    public Light Light;
    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
	
	}
    public void LightUp()
    {
        Light.intensity = 0.8f;
    }
    public void SaveBear()
    {
        Light.intensity = 0f;
    }
}

