using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Mint : MonoBehaviour
{
    public static event HandleMintCollected OnMintCollected;

    // define the return type and argument to match the inventory.AddItem
    public delegate void HandleMintCollected(ItemData itemData);
    public ItemData mintData;

    // After press, the event will be fired 
    public void Collect() {
        // Destroy(gameObject);
        OnMintCollected?.Invoke(mintData);
        Destroy(gameObject);
    }
}
