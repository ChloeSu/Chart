using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class gaze : MonoBehaviour {

    float timer,FillTime=5f;
    bool GazeAt;
    public string Scence;
    //Coroutine WaitingTime;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (GazeAt)
        {
            timer += 1f;
            if (timer > FillTime)
            {
                //ExecuteEvents.Execute(gameObject, new PointerEventData(EventSystem.current), ExecuteEvents.pointerDownHandler);
                Application.LoadLevel(Scence);
            }
            print(timer);
        }
        timer = 0f;
        //print(GazeAt);
	}

    public void OnGazeEnter()
    {
        GazeAt = true;
        /*WaitingTime = StartCoroutine(FillBar());
        if(timer==FillTime)
        {
            Application.LoadLevel("");
        }*/
    }

    public void OnGazeExit()
    {
        GazeAt = false;
    }

    IEnumerator FillBar()
    {
        timer = 0f;

        while (timer < FillTime)
        {
            timer += 1f;
            if (GazeAt)
                continue;
            timer = 0f;  
        }
        yield return timer;
    }
}
