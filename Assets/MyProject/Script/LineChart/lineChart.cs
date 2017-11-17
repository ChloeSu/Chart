using UnityEngine;
using System.Collections;

public class lineChart : MonoBehaviour {

    private LineRenderer lineRenderer;
    private float[] counter;
    private float[] dist;

    //public Transform Origin;
    //public Transform Destination;

    public float LineDrawSpeed = 5f;


    public Transform[] Sphere;
    float[,] xyValue = new float[6, 2] { { 10f, 70f }, { 205f, 60f }, { 30f, 50f }, { 40f, 40f }, { 50f, 30f }, { 60f, 20f } };
    float[] tempArray = new float[6];
    float x = -3f;
    float y = 0f;

    float xlengh = 0.06f;
    float ylengh = 0.04f;

    void spherePosition()
    {
        for (int i = 0; i < Sphere.Length; i++)
        {
            //tempArray[i] = xyValue[i, 0];
           // BubbleSort(tempArray);
            Sphere[i].position = new Vector3((x + (xyValue[i, 0] * xlengh)), (y + (xyValue[i, 1] * ylengh)), Sphere[i].position.z);
        }
    }

    // Use this for initialization
    void Start()
    {
        lineRenderer = GetComponent<LineRenderer>();
        for (int i = 0; i < Sphere.Length-1; i++)
        {
            lineRenderer.SetPosition(i, Sphere[i].position);
            dist[i] = Vector3.Distance(Sphere[i].position, Sphere[i+1].position);
        }

        lineRenderer.SetWidth(.1f, .1f);
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < Sphere.Length-1; i++)
        {
            if (counter[i] < dist[i])
            {
                counter[i] += .1f / LineDrawSpeed;

                float x = Mathf.Lerp(0, dist[i], counter[i]);

                Vector3 pointA = Sphere[i].position;
                Vector3 pointB = Sphere[i + 1].position;

                Vector3 pointALongLine = x * Vector3.Normalize(pointB - pointA) + pointA;

                lineRenderer.SetPosition(i+1, pointALongLine);
            }
        }
    }

    private void BubbleSort(float[] vArray)
    {
        int i, j;
        float temp;
        for (i = vArray.GetUpperBound(0); i > 0; i--)  // 第幾輪Pass
        {
            for (j = 0; j < i; j++)
            {
                if (vArray[j] > vArray[j + 1])
                //上方">"若換成"<"則將會變成由大到小
                {
                    temp = vArray[j];  // 兩陣列元素內容互換
                    vArray[j] = vArray[j + 1];
                    vArray[j + 1] = temp;
                }
            }
        }

    }

}
