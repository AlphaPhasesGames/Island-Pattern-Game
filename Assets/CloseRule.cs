using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Pattern.Quest.Alpha.Phases.Games
{
    public class CloseRule : MonoBehaviour
    {
        [SerializeField] private GameObject rulePanel; // UI panel for the inventory
        [SerializeField] private Button closeInvButton;
        [SerializeField] private Button openInvButton;

        private bool isInvOpen; // Tracks the inventory's open state

        private void Awake()
        {
            openInvButton.onClick.AddListener(ToggleInventory);
            closeInvButton.onClick.AddListener(ToggleInventory);

            rulePanel.SetActive(false); // Ensure the panel is initially closed
            isInvOpen = false;
        }

        private void Update()
        {
            // Allow closing inventory with Escape or right-click
            if (isInvOpen && (Input.GetKeyDown(KeyCode.Escape) || Input.GetMouseButtonDown(1)))
            {
                ToggleInventory();
            }
        }

        // Toggle the inventory's visibility
        private void ToggleInventory()
        {
            isInvOpen = !isInvOpen;
            rulePanel.SetActive(isInvOpen); // Show/hide panel based on state
            Debug.Log(isInvOpen ? "Inventory Opening" : "Inventory Closing");
        }
    }
}
