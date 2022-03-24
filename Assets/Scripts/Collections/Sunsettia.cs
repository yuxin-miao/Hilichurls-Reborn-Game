using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Sunsettia : MonoBehaviour, ICollectible
{
    public static event HandleSunsettiaCollected OnSunsettiaCollected;

    // define the return type and argument to match the inventory.AddItem
    public delegate void HandleSunsettiaCollected(ItemData itemData);
    public ItemData sunsettiaData;
    public void Collect() {
        Destroy(gameObject);
        OnSunsettiaCollected?.Invoke(sunsettiaData);
    }
}
