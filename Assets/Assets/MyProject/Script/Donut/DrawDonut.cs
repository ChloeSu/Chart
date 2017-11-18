using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawDonut : MonoBehaviour
{

    float[] value;
    float[] percentage;

    // Use this for initialization
    void Start()
    {
        GameObject.Find("Donut").transform.Rotate(new Vector3(0, 90, 0));
        GameObject.Find("Donut").transform.localPosition = new Vector3(-2.25f, transform.localPosition.y, transform.localPosition.z);
        GameObject.Find("Donut").transform.localScale = new Vector3(0.05f, 0.05f, 0.05f);
        ComputePercent();
    }

    // Update is called once per frame
    void Update()
    {

    }

    //資料來源
    void ComputePercent()
    {
        float sum = 0;
        value = new float[9] { 50f, 86f, 42f, 97f, 68f, 73f, 31f, 20f, 17f };
        for (int i = 0; i < value.Length; i++)
        {
            sum += value[i];
        }

        percentage = new float[value.Length];

        for (int i = 0; i < value.Length; i++)
        {
            percentage[i] = value[i] / sum;
        }

        int a = 0;
        
 
        for (int i = 0; i < value.Length; i++)
        {
            int j=0;
            float R = Random.Range(0.0f, 10f);
            float G = Random.Range(0.0f, 10f);
            float B = Random.Range(0.0f, 10f);

            while (j < (360f * percentage[i]))
            {
               GameObject.Find("dc" + a.ToString()).GetComponent<Renderer>().material.color = new Color(R, G, B) ;
               j++;
               if (a < 360){ a++; }
            }
        }
   }
}
