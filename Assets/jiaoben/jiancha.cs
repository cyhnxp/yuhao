using UnityEngine;
using System.Collections;

public class jiancha : MonoBehaviour {
	void Start () {}
    int count;
    int count1;
	void Update () {
        if (gameObject.transform.position.y < 0)
        {
            count1 = GameObject.Find("Main Camera").GetComponent<ji>().count1++;
            count = GameObject.Find("Main Camera").GetComponent<ji>().count;
            GameObject.Find("Main Camera").GetComponent<ji>().shedanshu.text = "射弹数：" + count + "  消灭数：" + count1;
            Destroy(gameObject);
        }


	}
}
