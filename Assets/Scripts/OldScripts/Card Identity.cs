using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Card id and number")]
public class CardIdentity : ScriptableObject
{
    public int fragmentNun;
    public int cardNum;
    public string nameOfTheCard;
    public bool[] fragmentCheck;

    [SerializeField]
    private Dictionary<string, GameObject> _keytest;
}
