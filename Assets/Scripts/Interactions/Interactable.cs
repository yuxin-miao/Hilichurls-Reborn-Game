using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.InputSystem;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public UnityEvent interactAction;
    public InputAction inputAction;

    // Start is called before the first frame update
    void Start()
    {
        inputAction.Enable();
    }

    // Update is called once per frame
    void Update()
    {
        // if we are in range to interact 
        if (isInRange) {
            
            GameObject player = GameObject.Find("Player");

            // if player presses the key 
            if (inputAction.triggered) {
                // Fire event

                interactAction.Invoke();
                PopUpSystem popUpSystem = player.GetComponent<PopUpSystem>();
                if (popUpSystem) {
                    popUpSystem.Close();
                }
            }

        }
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        // collision object has player tag 
        if (collision.gameObject.CompareTag("Player")) {
            isInRange = true;
            PopUpSystem popUpSystem = collision.gameObject.GetComponent<PopUpSystem>();
            if (popUpSystem) {
                popUpSystem.PopUp("Press " + inputAction.bindings[0].ToDisplayString());
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision) {
        if (collision.gameObject.CompareTag("Player")) {
            isInRange = false;
            PopUpSystem popUpSystem = collision.gameObject.GetComponent<PopUpSystem>();
            if (popUpSystem) {
                popUpSystem.Close();
            }

        }
    }

    public void DestroyItem() {
        Destroy(gameObject);
    }
}
