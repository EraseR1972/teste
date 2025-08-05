/*
 * SPDX-FileCopyrightText: 2024 Espressif Systems (Shanghai) CO LTD
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using UnityEngine;

namespace UnityInventory
{
    public class Hotbar : MonoBehaviour
    {
        public InventorySlot[] slots = new InventorySlot[5];

        public bool Assign(int index, InventorySlot fromSlot)
        {
            if (index < 0 || index >= slots.Length) return false;
            slots[index] = fromSlot;
            return true;
        }
    }
}
