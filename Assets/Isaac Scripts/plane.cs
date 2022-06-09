using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class plane : MonoBehaviour
{

    public GameObject mesh;


   // Update is called once per frame

    float input;
    public float speed;
    
    void Update()
    {
        input = -Input.GetAxis("Horizontal");
        transform.Translate(input * Time.deltaTime * Vector3.left * 10);
        if (input < 0)
        {
            mesh.transform.eulerAngles = new Vector3(0, 0, -45);
        }
        else if (input == 0) 
        {
            mesh.transform.eulerAngles = new Vector3(0, 0, 0);
        }
        else if (input > 0)
        {
            mesh.transform.eulerAngles = new Vector3(0, 0, 45);
        }

    }
}
 