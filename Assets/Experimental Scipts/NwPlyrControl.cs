using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NwPlyrControl : MonoBehaviour
{
    [SerializeField]
    private Animator _animatorC;

    [SerializeField]
    private CharacterController _charaCtrl;

    public float speed = 502f;
    public float rotSpeed = 240.5f;

    [SerializeField]
    private float _grav = 20.5f;

    [SerializeField]
    private Vector3 _moveDirec = Vector3.zero;

    public inventory invent_urs;
    
    // Start is called before the first frame update
    void Start()
    {
        _animatorC = GetComponent<Animator>();
        _charaCtrl = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("horizontal");
        float y = Input.GetAxis("vertical");

    }


    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        IInventoryItem item = hit.collider.GetComponent<IInventoryItem>();

        if(item != null)
        {
            inventory.AddItem(item);
        }
    }
}
