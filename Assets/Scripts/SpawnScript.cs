using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnScript : MonoBehaviour
{
    public GameObject cone;
    public GameObject ball;
    public GameObject cube;
    public GameObject pyramid;

    void Update()
    {
        if (OVRInput.GetDown(OVRInput.Button.One))
        {
            Instantiate(cone, transform.position, Quaternion.identity);
        }
        if (OVRInput.GetDown(OVRInput.Button.Two))
        {
            Instantiate(ball, transform.position, Quaternion.identity);
        }
        if (OVRInput.GetDown(OVRInput.Button.Three))
        {
            Instantiate(cube, transform.position, Quaternion.identity);
        }
        if (OVRInput.GetDown(OVRInput.Button.Four))
        {
            Instantiate(pyramid, transform.position, Quaternion.identity);
        }
    }

}
