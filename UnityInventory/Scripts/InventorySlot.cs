/*
 * SPDX-FileCopyrightText: 2024 Espressif Systems (Shanghai) CO LTD
 *
 * SPDX-License-Identifier: Apache-2.0
 */

namespace UnityInventory
{
    public class InventorySlot
    {
        public Item item;
        public int quantity;

        public bool IsEmpty => item == null;
        public float TotalWeight => IsEmpty ? 0f : item.weight * quantity;

        public bool CanStack(Item other)
        {
            return !IsEmpty && item == other && item.stackable;
        }

        public void Clear()
        {
            item = null;
            quantity = 0;
        }
    }
}
