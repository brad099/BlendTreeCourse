using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwatController : MonoBehaviour
{

    // Heeloy necesiz

    [SerializeField] float _speed;
    private Rigidbody rb;
    private Animator anim;
    float Vertical;
    float Horizontal;   
    Vector3 direction;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        anim = GetComponent<Animator>();
    }


    void Update()
    {
        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");
       
    }
    void FixedUpdate() 
    {
        rb.MovePosition(rb.position + direction * _speed * Time.fixedDeltaTime);
        anim.SetFloat("moveX",direction.z);
        anim.SetFloat("moveZ",direction.x);
    }
}
