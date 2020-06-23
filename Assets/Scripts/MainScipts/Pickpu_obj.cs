using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickpu_obj : MonoBehaviour
{
    public Main_Inventory inventoryM;

    private void OnTriggerEnter(Collider other)
    {
        Material_Req material_rq = other.gameObject.GetComponent<Material_Req>();
    
        if(material_rq != null)
        {
            inventoryM.AddMaterialequest(material_rq.material, 1);

            other.gameObject.SetActive(false);

            Debug.Log("picked");
        }
    }
}
