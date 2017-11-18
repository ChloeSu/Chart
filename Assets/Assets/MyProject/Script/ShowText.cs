using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowText : MonoBehaviour {
    public GameObject[] text;

    public void Show(int i)
    {
        text[i].SetActive(true);
    }

    public void disappear(int i)
    {
        text[i].SetActive(false);
    }

}
