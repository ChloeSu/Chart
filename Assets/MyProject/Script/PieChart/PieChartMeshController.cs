using System.Collections;
using UnityEngine;

public class PieChartMeshController : MonoBehaviour
{
    PieChartMesh mPieChart;
    float[] mData= { 10f,70f,2f,18f};

    void start()
    { 
        mPieChart = gameObject.AddComponent<PieChartMesh>() as PieChartMesh;
        if (mPieChart != null)
        {
            mPieChart.Init(mData, 100, 0, 100, null);
           
            mPieChart.Draw(mData);
        }

    }

}
