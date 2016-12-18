using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ji: MonoBehaviour
{
     void Start() { }
     public int count = 0;
     public int count1 = 0;
     int speed = 10;
     public GameObject newobject;
     public Text shedanshu;
     public Camera c;
    void Update()
    {
        
        float x = Input.GetAxis("Horizontal") * Time.deltaTime * speed;
        float z = Input.GetAxis("Vertical") * Time.deltaTime * speed;
        float y = Input.GetAxis("F") * Time.deltaTime * speed;
        transform.Translate(x, 0, z);
        transform.Translate(0, y, 0);
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject n = Instantiate(newobject, transform.position, transform.rotation) as GameObject;
            Vector3 fwd = transform.TransformDirection(Vector3.forward);
            n.GetComponent<Rigidbody>().AddForce(fwd * 2800);
            count++;
            shedanshu.text = "射弹数：" + count + "  消灭数：" + count1; 
            Destroy(n, 3);
        }
            if (Input.GetKey(KeyCode.Q))
            {
                transform.Rotate(0, -25 * Time.deltaTime, 0, Space.Self);
            }
            if (Input.GetKey(KeyCode.E))
            {
                transform.Rotate(0, 25 * Time.deltaTime, 0, Space.Self);
            }
            if (Input.GetKey(KeyCode.Z))
            {
                transform.Rotate(-25 * Time.deltaTime, 0, 0, Space.Self);
            }
            if (Input.GetKey(KeyCode.C))
            {
                transform.Rotate(25 * Time.deltaTime, 0, 0, Space.Self);
            }
           
        
    }
}

