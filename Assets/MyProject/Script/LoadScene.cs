using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadScene : MonoBehaviour {

    string scence;

	public void LS(string SceneName)
	{
        scence = SceneName;
        StartCoroutine ("delay");  
	}
	IEnumerator delay()
	{
            yield return new WaitForSeconds(2f);
            Application.LoadLevel(scence);
	}
}
