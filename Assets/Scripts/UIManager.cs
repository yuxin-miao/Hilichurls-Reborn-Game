using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    public Inventory inventory;
    public InputHandler inputHandler;
    [Header("UI Window")]
    public GameObject selectWindow;
    public GameObject InventoryWindow;
    [Header("Inventory Items")]
    public GameObject inventorySlotPrefab;
    public Transform InventorySlotsParent;

    InventorySlot[] inventorySlots;
    private void Start()
    {
        inventorySlots = InventorySlotsParent.GetComponentsInChildren<InventorySlot>();
        inputHandler = FindObjectOfType<InputHandler>();
    }

    // called when user click inventory icon 
    public void UpdateUI()
    {
        #region inventory Plants
        for (int i = 0; i < inventorySlots.Length; i++)
        {
            if (i < inventory.inventory.Count)
            {
                if (inventorySlots.Length < inventory.inventory.Count)
                {
                    Instantiate(inventorySlotPrefab, InventorySlotsParent);

                    inventorySlots = InventorySlotsParent.GetComponentsInChildren<InventorySlot>();

                }
                inventorySlots[i].AddItem(inventory.inventory[i]);
            }
            else
            {
                inventorySlots[i].ClearInventorySlot();
            }
        }
        #endregion
    }

    public void HandleInventoryThroughSelectWindow()
    {
        inputHandler.inventoryFlag = !inputHandler.inventoryFlag;
        if (inputHandler.inventoryFlag) OpenInventory();
        else CloseInventory();
    }

    public void OpenInventory()
    {
        UpdateUI();
        InventoryWindow.SetActive(true);
    }

    public void CloseInventory()
    {
        InventoryWindow.SetActive(false);
    }
}
