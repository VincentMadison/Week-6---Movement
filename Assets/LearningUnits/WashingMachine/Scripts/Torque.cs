using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Torque : MonoBehaviour
{
    public float amount = 50f;
    // Start is called before the first frame update
    void Start()
    {
        float h = Input.GetAxis("Horizontal") * amount * Time.deltaTime;
        float v = Input.GetAxis("Vertical") * amount * Time.deltaTime;

        GetComponent<Rigidbody>().AddTorque(transform.up * h);
        GetComponent<Rigidbody>().AddTorque(transform.right * v);
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
