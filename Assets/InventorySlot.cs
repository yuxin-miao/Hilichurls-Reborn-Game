using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventorySlot : MonoBehaviour
{
    public Image icon;
    InventoryItem inventoryItem;

    public void AddItem(InventoryItem newItem)
    {
        inventoryItem = newItem;
        icon.sprite = inventoryItem.itemData.icon;
        icon.enabled = true;
        gameObject.SetActive(true);

    }

    public void ClearInventorySlot()
    {
        inventoryItem = null;
        icon.sprite = null;
        icon.enabled = false;
        gameObject.SetActive(false);
    }
}
