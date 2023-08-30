using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private Rigidbody rb;
    [SerializeField] Transform t;
    private void Awake()
    {
            
        rb = GetComponent<Rigidbody>();
    }
    private void Start()
    {

        //rb.velocity = t.position  * speed;
    }
}
