using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class eplane : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(transform.forward * Time.deltaTime * speed);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "wall")
        {
            GameObject.Find("Plane1").GetComponent<PlayerHealth>().ChangeHealth(-1);
            Destroy(gameObject);
        }
    }
}
