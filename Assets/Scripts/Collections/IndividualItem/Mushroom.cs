using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushroom : MonoBehaviour
{
    public static event HandleMushroomCollected OnMushroomCollected;

    // define the return type and argument to match the inventory.AddItem
    public delegate void HandleMushroomCollected(ItemData itemData);
    public ItemData mushroomData;

    // After press, the event will be fired 
    public void Collect() {
        // Destroy(gameObject);
        OnMushroomCollected?.Invoke(mushroomData);
        Destroy(gameObject);
    }
}
