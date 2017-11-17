using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class copyPIE : MonoBehaviour {

    public GameObject Pie;
    public GameObject PC;
    string PieName;
	// Use this for initialization
	void Start () {
        PieName = CreateRandomCode(8);
        for (int i = 0; i < 100; i++)
        {
            Instantiate(Pie, new Vector3(0, 0, -0.001f * i), Quaternion.Euler(0, -180, 0));
            GameObject.Find("PieChartCtrl(Clone)").transform.SetParent(PC.transform);
            GameObject.Find("PieChartCtrl(Clone)").name = PieName+"-"+ i.ToString();
            //Instantiate(Pie, transform.position, Quaternion.Euler(0, -180, 0));

        }
        PC.transform.Rotate(0, 180,0);
        PC.transform.localScale=new Vector3(1,1,1);
        //************************************************************************
        PC.transform.localPosition = new Vector3(3.48f, 2.5f, -8.88f);

    }

    public string CreateRandomCode(int Number)
    {
        string allChar = "0,1,2,3,4,5,6,7,8,9,a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
        string[] allCharArray = allChar.Split(',');
        string randomCode = "";

        for (int i = 0; i < Number; i++)
        {
            int t = Random.Range(0,36);
            randomCode += allCharArray[t];
        }
        return randomCode;
    }

    // Update is called once per frame
    void Update () {
		
	}
}
