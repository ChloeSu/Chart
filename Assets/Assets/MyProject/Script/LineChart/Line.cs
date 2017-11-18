using UnityEngine;
using System.Collections;

public class Line : MonoBehaviour
{

    public LineRenderer lineRenderer;
   // public LineRenderer lineRenderer1;
    public Color c1 = Color.yellow;
//    public Color c2 = Color.black;

    public Transform[] Sphere;
    float[,] xyValue = new float[6, 3] { { 30f, 65f, 1f }, { 35f, 60f,1f}, { 50f, 50f ,1f}, { 70f, 45f,2f }, { 70f, 80f,2f }, { 90f, 20f ,2f} };

    float x = -3f;
    float y = 0f;

    float xlengh = 0.06f;
    float ylengh = 0.04f;

    Vector3[] positions,pos;

    void Start()
    {
        LineRenderer lineRenderer = gameObject.AddComponent<LineRenderer>();

        lineRenderer.material = new Material(Shader.Find("Particles/Additive"));
        lineRenderer.SetColors(c1, c1);
        lineRenderer.SetWidth(.05f, .05f);

        //LineRenderer lineRenderer1 = gameObject.AddComponent<LineRenderer>();

       // lineRenderer1.material = new Material(Shader.Find("Particles/Additive"));
        //lineRenderer1.SetColors(c2, c2);
        //lineRenderer1.SetWidth(.05f, .05f);


        positions = new Vector3[6];
        pos = new Vector3[3];
        //Sphere.Length

        int a = 0;
        //設定點

        for (int i = 0; i < Sphere.Length; i++)
        {
            Sphere[i].position = new Vector3((x + (xyValue[i, 0] * xlengh)), (y + (xyValue[i, 1] * ylengh)), Sphere[i].position.z);
            positions[i] = Sphere[i].position;

        }
        /*if (i + 1 < Sphere.Length)
        {
            if (xyValue[i, 2] == xyValue[i + 1, 2])
            {*/

        //positions[i] = Sphere[i].position;


        /*}
        else
        {
            pos[a] = Sphere[i].position;
            a++;
        }

    }*/

       /* positions[0] = Sphere[0].position;
        positions[1] = Sphere[1].position;
        positions[2] = Sphere[2].position;

        pos[0] = Sphere[3].position;
        pos[1] = Sphere[4].position;
        pos[2] = Sphere[5].position;*/

    

        //設定線
        lineRenderer = GetComponent<LineRenderer>();


        lineRenderer.SetPositions(positions);

        /*lineRenderer1 = GetComponent<LineRenderer>();
        lineRenderer1.SetPositions(pos);*/

        //helpful

        /*for (int i = 0; i < Sphere.Length-1; i++)
        {
            print(xyValue[i, 2]+"/y//////////");
            print(xyValue[i + 1, 2]);
            if (xyValue[i, 2] == xyValue[i + 1, 2])
            {
                lineRenderer.SetPosition(i, Sphere[i].position);
            }

           
        }*/
        
        //lineRenderer.SetVertexCount(Sphere.Length);

        //loser

       /* lineRenderer.SetVertexCount(positions.Length);
        print(positions.Length);
        lineRenderer.SetPositions(positions);
        lineRenderer.SetPositions(pos);*/



    }

    // Update is called once per frame
    void Update()
    {
        lineRenderer = GetComponent<LineRenderer>();
        //lineRenderer1 = GetComponent<LineRenderer>();
        /*for (int i = 0; i < Sphere.Length; i++)
        {
            print(xyValue[i, 2]+"QQ");
            print(xyValue[i + 1, 2]);
            if (xyValue[i, 2] == xyValue[i + 1, 2])
            {
                lineRenderer.SetPosition(i, Sphere[i].position);
            }
        }*/

        lineRenderer.SetVertexCount(positions.Length);
        //lineRenderer1.SetVertexCount(pos.Length);
        lineRenderer.SetPositions(positions);
        //lineRenderer1.SetPositions(pos);



    }
}
