using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    public bool inventory_Input;

    public bool inventoryFlag;

    PlayerInputActions inputActions;
    UIManager uIManager;

    private void Awake()
    {
        uIManager = FindObjectOfType<UIManager>();
    }
    public void OnEnable()
    {
        if (inputActions == null)
        {
            inputActions = new PlayerInputActions();

        }
        inputActions.Enable();


    }
    public void TickInput(float delta)
    {
        HandleInventoryInput();
    }
    private void HandleInventoryInput()
    {
        inputActions.Player.Inventory.performed += i => inventory_Input = true;

        if (inventory_Input)
        {
            inventoryFlag = !inventoryFlag;
            if (inventoryFlag)
            {
                uIManager.OpenInventory();
            }
            else {
                uIManager.CloseInventory();
            }
        }
    }
}