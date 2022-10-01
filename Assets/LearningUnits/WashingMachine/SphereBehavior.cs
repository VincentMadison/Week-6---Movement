using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBehavior : MonoBehaviour
{
    [SerializeField] Vector3 moveDirection;

    void Start()
    {

    }
    

    void Update()
    {
        transform.position = transform.position + moveDirection;
        Debug.Log(transform.position);
    }
}