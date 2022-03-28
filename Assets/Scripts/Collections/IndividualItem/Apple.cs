using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class Apple : MonoBehaviour
{
    public static event HandleAppleCollected OnAppleCollected;

    // define the return type and argument to match the inventory.AddItem
    public delegate void HandleAppleCollected(ItemData itemData);
    public ItemData appleData;

    // After press, the event will be fired 
    public void Collect() {
        // Destroy(gameObject);
        OnAppleCollected?.Invoke(appleData);
        Destroy(gameObject);
    }
}
