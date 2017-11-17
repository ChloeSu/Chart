using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System;
using System.Linq;
using System.Collections.Generic;

public class length : MonoBehaviour {

    float[] start = new float[5] { 0,0,0,0,0};
    float[] SV = new float[5] { 0.22f,0.33f,0.63f,0.75f,0.99f};
    float[] value=new float[5];
    int[] compute=new int[5];

	// Update is called once per frame
	void Update ()
    {
        for (int i = 0; i < value.Length; i++)
        {
            String Sname = "Slider" + i.ToString();
            String Tname = "Text" + i.ToString();
            value[i] = GameObject.Find(Sname).GetComponent<Slider>().value;
            if (SV[i] > value[i])
            {
                start[i] += 0.01f;
                GameObject.Find(Sname).GetComponent<Slider>().value = start[i];
            }
            compute[i] = Convert.ToInt16(Math.Floor(value[i] * 100));

            GameObject.Find(Tname).GetComponent<Text>().text = compute[i].ToString();
        }
    }    
}
