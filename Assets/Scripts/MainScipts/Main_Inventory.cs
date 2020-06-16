using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Material_C
{
    Paper = 0,
    Ink = 1,
    Image = 2,
    Holo_Sheet = 3,
    Golden_Edges = 4
}

public enum Card_Status
{
    Not_Avaible = 0,
    Avaible = 1
}

public enum Card_List
{
    Card_Name_A = 0,
    Card_Name_B = 1,
    Card_Name_C = 2,
    Card_Name_D = 3,
    Card_Name_E = 4,
    Card_Name_F = 5,
    Card_Name_G = 6,
    Card_Name_H = 7,
    Card_Name_I = 8,
    Card_Name_J = 9,
    Card_Name_K = 10,
    Card_Name_L = 11,
    Card_Name_M = 12,
    Card_Name_N = 13,
    Card_Name_Ñ = 14,
    Card_Name_O = 15,
    Card_Name_P = 16,
    Card_Name_Q = 17,
    Card_Name_R = 18,
    Card_Name_S = 19,
    Card_Name_T = 20,
    Card_Name_U = 21,
    Card_Name_V = 22,
    Card_Name_W = 23,
    Card_Name_X = 24,
    Card_Name_Y = 25,
    Card_Name_Z = 26,
    Card_Name_AA = 27,
    Card_Name_AB = 28,
    Card_Name_AC = 29,
    Card_Name_AD = 30,
    Card_Name_AE = 31,
    Card_Name_AF = 32,
    Card_Name_AG = 33,
    Card_Name_AH = 34,
    Card_Name_AI = 35,
    Card_Name_AJ = 36,
    Card_Name_AK = 37,
    Card_Name_AL = 38,
    Card_Name_AM = 39,
    Card_Name_AN = 40,
    Card_Name_AÑ = 41,
    Card_Name_AO = 42,
}

[System.Serializable]
public class Material_Reque
{
    public Material_C Material_rq;
    public int cuanta;
}

[System.Serializable]
public class Iden_Card
{
    public Card_List listC;
    public Card_Status check;

    public Material_Reque Material_Reque_Paper;
    public Material_Reque Material_Reque_Ink;
    public Material_Reque Material_Reque_Image;
    public Material_Reque Material_Reque_Holo;
    public Material_Reque Material_Reque_Gold;
}

public class Main_Inventory : MonoBehaviour
{
    public Material_Reque[] reque;
    public Iden_Card[] idenC;

    public Card_data[] cardData;

    private bool havematA;
    private bool havematB;
    private bool havematC;
    private bool havematD;
    private bool havematE;

    private bool goalCheck;

    public void AddMaterialequest(Material_C type, int quantRq)
    {
        reque[(int)type].cuanta += quantRq;
    }

    public void Awake()
    {
        for (int i = 0; i < cardData.Length; i++)
        {
            if(idenC[i].check == Card_Status.Avaible)
            {
                cardData[i].gameObject.SetActive(false);
            }
        }
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.T)) 
        {
            for (int y = 0; y < idenC.Length; y++)
            {
                GoalCondition();
            }
        }
        
    }

    public void TransformMat(Card_List material)
    {
        havematA = reque[(int)Material_C.Paper].cuanta >= idenC[(int)material].Material_Reque_Paper.cuanta;
        havematB = reque[(int)Material_C.Ink].cuanta >= idenC[(int)material].Material_Reque_Ink.cuanta;
        havematC = reque[(int)Material_C.Image].cuanta >= idenC[(int)material].Material_Reque_Image.cuanta;
        havematD = reque[(int)Material_C.Holo_Sheet].cuanta >= idenC[(int)material].Material_Reque_Holo.cuanta;
        havematE = reque[(int)Material_C.Golden_Edges].cuanta >= idenC[(int)material].Material_Reque_Gold.cuanta;

        if(havematA&&havematB&&havematC&&havematD&&havematE == true)
        {
            idenC[(int)material].check = Card_Status.Avaible;
            cardData[(int)material].gameObject.SetActive(false);

            AddMaterialequest(Material_C.Paper, idenC[(int)material].Material_Reque_Paper.cuanta);
            AddMaterialequest(Material_C.Ink, idenC[(int)material].Material_Reque_Ink.cuanta);
            AddMaterialequest(Material_C.Image, idenC[(int)material].Material_Reque_Image.cuanta);
            AddMaterialequest(Material_C.Holo_Sheet, idenC[(int)material].Material_Reque_Holo.cuanta);
            AddMaterialequest(Material_C.Golden_Edges, idenC[(int)material].Material_Reque_Gold.cuanta);
        }
    }

    public void GoalCondition()
    {
        goalCheck = true;

        for (int i = 0; i < idenC.Length; i++)
        {
            if(idenC[i].check != Card_Status.Avaible)
            {
                goalCheck = false;
                break;
            }
        }

        if(goalCheck)
        {
            Application.Quit();
        }
    }

}
