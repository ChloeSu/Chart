using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AreaForChangeColor : MonoBehaviour {
    public  Material mat,mat1;

    public void ChangeColor(GameObject land)
    {
        land.GetComponent<Renderer>().material=mat;
    }

    public void NormalColor(GameObject land)
    {
        land.GetComponent<Renderer>().material = mat1;
    }
}
