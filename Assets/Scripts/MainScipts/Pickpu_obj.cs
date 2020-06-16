using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pickpu_obj : MonoBehaviour
{
    public Main_Inventory inventoryM;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name.Contains("Material_Rqst"))
        {
            inventoryM.AddMaterialequest(other.gameObject.GetComponent<Material_Req>().material, 1);

            other.gameObject.SetActive(false);
        }
    }
}
