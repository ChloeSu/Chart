using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawline : MonoBehaviour
{

    private LineRenderer lineRenderer;
    private float counter;
    private float dist;

    public Transform Origin;
    public Transform Destination;

    public float LineDrawSpeed = 5f;

    // Use this for initialization
    void Start()
    {
        StartCoroutine(wait());
        lineRenderer = GetComponent<LineRenderer>();
        lineRenderer.SetPosition(0, Origin.position);
        lineRenderer.SetWidth(.1f, .1f);

        dist = Vector3.Distance(Origin.position, Destination.position);
    }

    // Update is called once per frame
    void Update()
    {
        if (counter < dist)
        {
            counter += .1f / LineDrawSpeed;

            float x = Mathf.Lerp(0, dist, counter);

            Vector3 pointA = Origin.position;
            Vector3 pointB = Destination.position;

            Vector3 pointALongLine = x * Vector3.Normalize(pointB - pointA) + pointA;

            lineRenderer.SetPosition(1, pointALongLine);

        }
    }
    private IEnumerator wait()
    {
        yield return new WaitForSeconds(5);
    }
}
