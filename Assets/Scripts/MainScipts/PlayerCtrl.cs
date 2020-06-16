using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCtrl : MonoBehaviour
{
    [SerializeField]
    private float speed = 10.5F;
    [SerializeField]
    private Rigidbody _rigidbodyT;
    [SerializeField]
    private float _jumpVel = 5.5f;

    //[SerializeField]
    //private bool _iscolliding;

    [SerializeField]
    private GameObject Itemcolect;

    
    void Start()
    {
        _rigidbodyT = GetComponent<Rigidbody>();
        //_iscolliding = false;
    }

    // Update is called once per frame
    void Update()
    {
        PlayerMove();
    }

    public void PlayerMove()
    {
        float deltaX = Input.GetAxis("Horizontal");
        float deltaY = Input.GetAxis("Jump");
        float deltaZ = Input.GetAxis("Vertical");

        _rigidbodyT.AddForce(deltaX * speed, deltaY * _jumpVel, deltaZ * speed);
    }

    /*
    public void OnTriggerEnter(Collider other)
    {
        _iscolliding = true;
        Itemcolect = other.gameObject;
    }

    public void OnTriggerExit(Collider other)
    {
        _iscolliding = false;
        Itemcolect = null;
    }
    */
}
    

