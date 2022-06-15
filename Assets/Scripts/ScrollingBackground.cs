using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScrollingBackground : MonoBehaviour
{

    public GameObject background;

    public float speed;
    public float loopZ;
    public float startZ;
    // Start is called before the first frame update
    void Start()
    {
        loopZ = -background.GetComponentInChildren<BoxCollider>().bounds.size.z;
    }

    // Update is called once per frame
    void Update()
    {
        background.transform.Translate(transform.forward * speed * Time.deltaTime);

        // check if the current background should loop
        if (background.transform.position.z <= loopZ)
        {
            background.transform.position = new Vector3(0, transform.position.y, startZ);
        }
    }
}
