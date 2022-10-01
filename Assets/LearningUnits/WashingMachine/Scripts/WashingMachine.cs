using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WashingMachine : MonoBehaviour
{
    [SerializeField] private Vector3 _rotation;
    [SerializeField] private Vector3 moveDirection;

    // Start is called before the first frame update
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(moveDirection, ForceMode.Force);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(_rotation * Time.deltaTime);
    }
}
