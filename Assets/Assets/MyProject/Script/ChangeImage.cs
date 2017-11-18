using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Sprites;

public class ChangeImage : MonoBehaviour {

	public Sprite[] backgrounds;
	public GameObject[] btn;
	public GameObject panel;
	public string Pic;
	Image img;
	bool c=false;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClickChangeBackground(string PicName)
	{
		Pic = PicName;
		StartCoroutine (delay());
	}
		
	IEnumerator delay()
	{
		yield return new WaitForSeconds (1f);
		Change ();
	}

	public void Change()
	{
		if (Pic == "Asia") {

			panel.GetComponent <Image> ().sprite = backgrounds [1];
			btn [0].SetActive (false);
			btn [1].SetActive (true);
			btn [2].SetActive (false);

		} else if (Pic == "Big") {

			panel.GetComponent<Image> ().sprite = backgrounds [2];
			btn [0].SetActive (false);
			btn [1].SetActive (false);
			btn [2].SetActive (true);

		} else if (Pic == "Taiwan") {
			
				panel.GetComponent<Image> ().sprite = backgrounds [3];
				btn [0].SetActive (false);
				btn [1].SetActive (false);
				btn [2].SetActive (false);

		} else {
			
			panel.GetComponent<Image> ().sprite = backgrounds [0];
			btn [1].SetActive (true);
		}
	}
}
