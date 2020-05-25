using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    //public int exp;
    public int hp;
    //public int mp;
    public MegaItem mitem;

    public Text uitext;

    public float speed;
    private Rigidbody rbody;
    private inventory inventory;

    private GameObject collision;
    private bool iscolliding;

    [SerializeField]
    private CharacterController _charContr;
    [SerializeField]
    private float _turningSmoothTime = 0.1f;
    [SerializeField]
    private float _turnigSmoothVelocity;
    [SerializeField]
    private Transform cam;


    void Start()
    {
        rbody = GetComponent<Rigidbody>();
        inventory = GetComponent<inventory>();
        iscolliding = false;

        RefreshUI();
    }
    void Update()
    {
        //MoveInputPlyr();

        NewPlyrMov();
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("tooth");
        iscolliding = true;
        collision = other.gameObject;
    }
    private void OnTriggerExit(Collider other)
    {
        Debug.Log("tooth");
        iscolliding = false;
        collision = null;
    }
    public void RefreshUI()
    {
        //uitext.text = "Exp: " + exp + "\n";
        uitext.text += "HP: " + hp + "/100\n";
        //uitext.text += "MP: " + mp + "/100\n";
        uitext.text += "MegaItem Ready: " + mitem.Completed().ToString() + "\n";
    }

    public void MoveInputPlyr()
    {
        float deltaz = Input.GetAxis("Vertical");
        float deltax = Input.GetAxis("Horizontal");

        rbody.velocity = speed * new Vector3(deltax, 0, deltaz);

        if (iscolliding && collision != null && Input.GetKeyDown(KeyCode.E))
        {
            inventory.AddItem(collision.GetComponent<Item>());
            iscolliding = false;
            collision = null;
        }
        if (Input.GetKeyDown(KeyCode.Q))
        {
            Item item = inventory.Use();
            if (item != null)
            {
                switch (item.type)
                {
                    /*case Item.ItemType.EXP:
                        exp += 10;
                        break;*/
                    case Item.ItemType.HEART:
                        hp += 10;
                        if (hp > 100)
                            hp = 100;
                        break;
                    /*case Item.ItemType.POTION:
                        mp += 10;
                        if (mp > 100)
                            mp = 100;
                        break;*/
                    case Item.ItemType.FRAGMENT:
                        mitem.AddFragment(item);
                        break;
                }
                RefreshUI();
            }
        }
    }

    public void NewPlyrMov()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction_ = new Vector3(horizontal, 0f, vertical).normalized;

        if(direction_.magnitude >= 0.1f)
        {
            float targetAngle = Mathf.Atan2(direction_.x, direction_.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float angle = Mathf.SmoothDampAngle(transform.eulerAngles.y, targetAngle, 
                ref _turnigSmoothVelocity,_turningSmoothTime);
            transform.rotation = Quaternion.Euler(0f, angle, 0f);

            Vector3 moveDir_t = Quaternion.Euler(0f, targetAngle, 0f) * Vector3.forward;
            _charContr.Move(moveDir_t.normalized * speed * Time.deltaTime);
        }

        if (iscolliding && collision != null && Input.GetKeyDown(KeyCode.E))
        {
            inventory.AddItem(collision.GetComponent<Item>());
            iscolliding = false;
            collision = null;
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            Item item = inventory.Use();
            if (item != null)
            {
                switch (item.type)
                {
                    /*case Item.ItemType.EXP:
                        exp += 10;
                        break;*/
                    case Item.ItemType.HEART:
                        hp += 10;
                        if (hp > 100)
                            hp = 100;
                        break;
                    /*case Item.ItemType.POTION:
                        mp += 10;
                        if (mp > 100)
                            mp = 100;
                        break;*/
                    case Item.ItemType.FRAGMENT:
                        mitem.AddFragment(item);
                        break;
                }
                RefreshUI();
            }
        }

    }
    
}
