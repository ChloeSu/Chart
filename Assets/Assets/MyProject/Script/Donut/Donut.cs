﻿using UnityEngine;
using System.Collections;

public class Donut : MonoBehaviour
{
    public GameObject circleModel;
    //旋转改变的角度
    public int changeAngle = 0;
    public GameObject donut;
    //旋转一周需要的预制物体个数
    private int count;

    private float angle = 0;
    public float r = 5;

    // Use this for initialization
    void Start()
    {
        count = (int)360 / changeAngle;
        for (int i = 0; i < count; i++)
        {
            Vector3 center = circleModel.transform.position;
            Instantiate(circleModel, transform.position, transform.rotation);
            GameObject.Find("donutcube(Clone)").transform.SetParent(donut.transform);
            GameObject.Find("donutcube(Clone)").name = "dc"+i.ToString();
            float hudu = (angle / 180) * Mathf.PI;
            float xx = center.x + r * Mathf.Cos(hudu);
            float yy = center.y + r * Mathf.Sin(hudu);
            GameObject.Find("dc" + i.ToString()).transform.position = new Vector3(xx, yy, 0);
            GameObject.Find("dc" + i.ToString()).transform.LookAt(center);
            angle += changeAngle;
        }
    }
}