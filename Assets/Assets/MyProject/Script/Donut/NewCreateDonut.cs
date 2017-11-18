using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewCreateDonut : MonoBehaviour {

    float[] value;
    float[] percentage;

    public int K;
    // Use this for initialization
    void Start () {
        DrawRing(.2f, .5f, 50, Vector3.zero,K);
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    void DrawRing(float radius, float innerRadius, int segments, Vector3 centerCircle,int K)
    {

        float sum = 0;

        if(K==0)
            value = new float[6] { 50f, 0f,0f, 0f,99f,33f};      
        else if (K == 1)
            value = new float[10] { 0f, 80f, 0f, 5f, 0f , 0f, 0f,0f ,0f,20f};
        else if (K == 2)
            value = new float[4] { 50f, 86f, 0f, 97f};
        else if (K == 3)
            value = new float[5] { 50f, 86f, 0f, 97f, 68f};
        else if (K == 4)
            value = new float[6] { 0f, 86f, 0f, 97f, 0f, 73f};
        else if (K == 5)
            value = new float[7] { 0f, 86f, 0f, 0f, 68f, 73f, 0f};
        else if (K == 6)
            value = new float[7] { 0f, 86f, 0f, 58f, 0f, 72f, 102f };
        else if (K == 7)
            value = new float[10] { 50f, 86f, 0f, 0f, 50f, 73f, 0f, 0f, 33f, 66f };
        else if (K == 8)
            value = new float[10] { 1000f, 500f, 300f, 100f, 50f, 80f, 30f, 100f, 200f, 200f };
        else if (K == 9)
            value = new float[7] { 0f, 86f, 0f, 0f, 68f, 73f, 0f };
        else if (K == 10)
            value = new float[7] { 0f, 86f, 0f, 0f, 68f, 73f, 0f };



        //value = new float[8] { 50f, 86f, 42f, 97f, 68f, 73f, 88f, 99f };
        for (int i = 0; i < value.Length; i++)
        {
            sum += value[i];
        }

        percentage = new float[value.Length];

        for (int i = 0; i < value.Length; i++)
        {
            percentage[i] =value[i] / sum;
        }



        // gameObject.AddComponent<MeshFilter>();
        //  gameObject.AddComponent<MeshRenderer>();

        Mesh mesh = GetComponent<MeshFilter>().mesh;
        mesh.Clear();
        mesh.name = "Donut Chart Mesh";

        //頂點
        Vector3[] vertices = new Vector3[segments * 2];
        float deltaAngle = Mathf.Deg2Rad * 360f / segments;
        float currentAngle = 0;
        for (int i = 0; i < vertices.Length; i += 2)
        {
            float cosA = Mathf.Cos(currentAngle);
            float sinA = Mathf.Sin(currentAngle);
            vertices[i] = new Vector3(cosA * innerRadius + centerCircle.x, sinA * innerRadius + centerCircle.y, 0);
            vertices[i + 1] = new Vector3(cosA * radius + centerCircle.x, sinA * radius + centerCircle.y, 0);
            currentAngle += deltaAngle;
        }

        //三角形

        mesh.subMeshCount = value.Length;
        int[][] subTris = new int[value.Length][];
        int[] triangles = new int[segments * 6];
        int countedSlices = 0;
        for (int k = 0; k < value.Length; k++)
        {
            subTris[k] = new int[segments * 6];

            for (int i = 0, j = 0; i < segments * 6; i += 6, j += 2)
            {
                triangles[i] = j;
                triangles[i + 1] = (j + 1) % vertices.Length;
                triangles[i + 2] = (j + 3) % vertices.Length;

                triangles[i + 3] = j;
                triangles[i + 4] = (j + 3) % vertices.Length;
                triangles[i + 5] = (j + 2) % vertices.Length;
            }

            AdjustPercentage();
            //Mathf.Round(50f * percentage[k])
            for (int m = 0; m < Mathf.Round(50f * percentage[k]); m++)
            {
                subTris[k][m * 6 + 0] = triangles[countedSlices * 6 + 0];
                subTris[k][m * 6 + 1] = triangles[countedSlices * 6 + 1];
                subTris[k][m * 6 + 2] = triangles[countedSlices * 6 + 2];
                subTris[k][m * 6 + 3] = triangles[countedSlices * 6 + 3];
                subTris[k][m * 6 + 4] = triangles[countedSlices * 6 + 4];
                subTris[k][m * 6 + 5] = triangles[countedSlices * 6 + 5];
                countedSlices++;
            }

        }
        mesh.vertices = vertices;
        for (int i = 0; i < value.Length; i++)
        {
            mesh.SetTriangles(subTris[i], i);
        }
    }

    //調整百分比
    public void AdjustPercentage()
    {
        float temp = 0;
        for (int i = 0; i < value.Length; i++)
        {
            temp += Mathf.Round(50f * percentage[i]);
        }
        if ((50 - temp) != 0)
        {
            if( ( 50 - temp ) > 0)
                percentage[0] += 0.01f * (2 * ( 50 - temp) - 1);
            else
                percentage[0] -= 0.012f * (2 * (-1) * ( 50 - temp) - 1);
        }
    }
}
