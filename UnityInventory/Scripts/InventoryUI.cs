/*
 * SPDX-FileCopyrightText: 2024 Espressif Systems (Shanghai) CO LTD
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using UnityEngine;

namespace UnityInventory
{
    public class InventoryUI : MonoBehaviour
    {
        public GameObject inventoryRoot;
        public Inventory inventory;
        public Hotbar hotbar;

        private bool _visible;

        private void Start()
        {
            if (inventoryRoot != null)
            {
                inventoryRoot.SetActive(false);
            }
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.I))
            {
                Toggle();
            }
        }

        public void Toggle()
        {
            _visible = !_visible;
            if (inventoryRoot != null)
            {
                inventoryRoot.SetActive(_visible);
            }
        }
    }
}
