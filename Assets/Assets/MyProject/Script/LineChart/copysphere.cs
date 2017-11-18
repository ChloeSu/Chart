using UnityEngine;
using System.Collections;

public class copysphere : MonoBehaviour {
    public GameObject sphere;
    // Use this for initialization
    void Start () {

        for (int i = 0; i < 5; i++)
        {
            float X = transform.position.x + Random.Range(-10.0F, 10.0F);
            //以目前物件的x座標為基準，亂數生成正負10的範圍做為新生成物件的x座標
            float Z = transform.position.z + Random.Range(-10.0F, 10.0F);
            //以目前物件的z座標為基準，亂數生成正負10的範圍做為新生成物件的z座標
            Vector3 A = new Vector3(X, transform.position.y + 0.5F, Z);
            //new Vector3的y座標為取得之高度再加0.5F，防止新物件掉落地表下
            Instantiate(sphere, A, transform.rotation);
            //生成新物件(複製在場景內的Sphere物件到A點，旋轉角度和目前物件相同)
        }

    }
	
	// Update is called once per frame
	void Update () {

        
    }

}
