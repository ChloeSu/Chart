using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pointerRotate : MonoBehaviour {
    
    float start,end,degree;
    public float percentage;
    int cnt = 1;
    public Text text;

    private void Start()
    {
        //開始角度,結束角度
        start = 115f;
        end = -116f;
        //每一個百分比旋轉幾度
        degree = (Mathf.Abs(end-start))/ 100;
    }
    // Use this for initialization
    private void Update()
    {
        if (percentage!=0 && cnt< percentage)
        {
            this.transform.Rotate(0, 0, degree);
            cnt++;
            text.text = cnt.ToString()+"%";
        }
    }

}
