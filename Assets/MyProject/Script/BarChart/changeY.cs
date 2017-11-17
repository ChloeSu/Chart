using UnityEngine;
using System.Collections;
using System;
using UnityEngine.UI;

public class changeY : MonoBehaviour {


    float[] start;
    float[] SV;//長條圖的長度
    float[] value;//目前暫存的值
    int[] compute ;
    int num;
    public Transform cube;
    public Transform text;
    public GameObject Bar;
    string BarName ;

    void Start()
    {
        BarName = CreateRandomCode(8);
        barDisplay();
        XYaxis();    
    }
   
    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < num; i++)
        {

            if (SV[i] > value[i])
            {
                GameObject.Find(BarName+"-"+i.ToString()).transform.localScale+= new Vector3(0,0.01f,0);
                value[i] += 0.01f;

            }

            
        }
    }

    void barDisplay()
    {
        SV = new float[5] { 0.22f, 0.45f, 1f ,0.11f,0.22f};

        num = SV.Length;

        value = new float[num];

        compute = new int[num];

        start = new float[num];
        for (int i = 0; i < num; i++)
        {
            start[i] = 0;
            float temp= 6f / (num - 1f);

            Instantiate(cube, new Vector3(i, i, i), transform.rotation);
            Instantiate(text, new Vector3(i, i, i), transform.rotation);

            GameObject.Find("cube(Clone)").transform.SetParent(Bar.transform);
            GameObject.Find("barText(Clone)").transform.SetParent(Bar.transform);

            GameObject.Find("cube(Clone)").transform.localPosition = new Vector3(-6f + (temp) * (i), -2f, 0);
            GameObject.Find("barText(Clone)").transform.localPosition = new Vector3(-6f + (temp) * (i) -0.225f, 3.5f, 0);

            GameObject.Find("cube(Clone)").transform.localScale = new Vector3(1, 0, 1);
            GameObject.Find("barText(Clone)").transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);

            GameObject.Find("cube(Clone)").name = BarName+"-"+i.ToString();
            GameObject.Find("barText(Clone)").name = "_"+BarName+"-"+i.ToString();

            GameObject.Find("_" + BarName + "-" + i.ToString()).transform.GetComponent<TextMesh>().text = (SV[i]*100).ToString();

        }


    }

    void XYaxis()
    {
        for (int y = 0; y < 5; y++)
        {
            Instantiate(text, new Vector3(y, y, y), transform.rotation);
            GameObject.Find("barText(Clone)").transform.SetParent(Bar.transform);
            GameObject.Find("barText(Clone)").transform.localPosition = new Vector3(-7.75f, -1.8f + (5f / 4f * y), 0);
            GameObject.Find("barText(Clone)").transform.localScale = new Vector3(0.5f, 0.5f, 0.5f);
            GameObject.Find("barText(Clone)").name = BarName + "Yaxis" + y.ToString();
            GameObject.Find(BarName + "Yaxis" + y.ToString()).transform.GetComponent<TextMesh>().text = (25 * y).ToString() + "%";

        }

        for (int x = 0; x < num; x++)
        {
            Instantiate(text, new Vector3(x, x, x), transform.rotation);
            GameObject.Find("barText(Clone)").transform.SetParent(Bar.transform);
            GameObject.Find("barText(Clone)").transform.localPosition = new Vector3(-6f + (6f / (num - 1f)) * (x) - 0.25f, -2.75f, 0);
            GameObject.Find("barText(Clone)").transform.localScale = new Vector3(0.2f, 0.2f, 0.2f);
            GameObject.Find("barText(Clone)").name = BarName + "Xaxis" + x.ToString();
            GameObject.Find(BarName + "Xaxis" + x.ToString()).transform.GetComponent<TextMesh>().text = (-6f + (6f / (num - 1f)) * (x) - 0.25f).ToString();

        }

    }

    public string CreateRandomCode(int Number)
    {
        string allChar = "0,1,2,3,4,5,6,7,8,9,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
        string[] allCharArray = allChar.Split(',');
        string randomCode = "";

        for (int i = 0; i < Number; i++)
        {
            int t = UnityEngine.Random.Range(0, 36);
            randomCode += allCharArray[t];
        }
        return randomCode;
    }
}
