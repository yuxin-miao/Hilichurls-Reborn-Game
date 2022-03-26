using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SweetFlower : MonoBehaviour
{
    public static event HandleSweetFlowerCollected OnSweetFlowerCollected;

    // define the return type and argument to match the inventory.AddItem
    public delegate void HandleSweetFlowerCollected(ItemData itemData);
    public ItemData sweetFlowerData;

    // After press, the event will be fired 
    public void Collect() {
        // Destroy(gameObject);
        OnSweetFlowerCollected?.Invoke(sweetFlowerData);
        Destroy(gameObject);
    }
}
