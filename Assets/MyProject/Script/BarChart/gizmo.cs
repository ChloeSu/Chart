using UnityEngine;
using System.Collections;

public class gizmo : MonoBehaviour {

    public float gizmoSize = 0.75f;
    public Color gizmoColor = Color.yellow;


    void onDrawGizmos()
    {
        Gizmos.color = gizmoColor;
        Gizmos.DrawWireSphere(transform.position, gizmoSize);
    }
}
