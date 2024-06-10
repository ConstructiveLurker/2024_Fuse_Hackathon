using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScaleScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
 public GameObject obj;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.U))
        {
            obj.gameObject.transform.localScale += new Vector3(0.01f, 0.01f, 0.01f);
        }
        if (Input.GetKey(KeyCode.I))
        {
            obj.gameObject.transform.localScale -= new Vector3(0.01f, 0.01f, 0.01f);
        }
    }
}
