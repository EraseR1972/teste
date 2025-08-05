/*
 * SPDX-FileCopyrightText: 2024 Espressif Systems (Shanghai) CO LTD
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using UnityEngine;

namespace UnityInventory
{
    public class TestAddItem : MonoBehaviour
    {
        public Inventory inventory;
        public Item[] testItems;

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.T))
            {
                if (testItems.Length > 0)
                {
                    var item = testItems[Random.Range(0, testItems.Length)];
                    inventory.AddItem(item, 1);
                }
            }
        }
    }
}
