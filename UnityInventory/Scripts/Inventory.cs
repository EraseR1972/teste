/*
 * SPDX-FileCopyrightText: 2024 Espressif Systems (Shanghai) CO LTD
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using System.Collections.Generic;
using UnityEngine;

namespace UnityInventory
{
    public class Inventory : MonoBehaviour
    {
        [Header("Settings")]
        public int cargoSlotCount = 16;
        public float weightLimit = 100f;

        [Header("Special Slots")]
        public InventorySlot fuelSlot = new InventorySlot();
        public InventorySlot weaponSlot = new InventorySlot();
        public InventorySlot moduleSlot = new InventorySlot();

        public List<InventorySlot> cargoSlots = new List<InventorySlot>();

        private void Awake()
        {
            for (int i = 0; i < cargoSlotCount; i++)
            {
                cargoSlots.Add(new InventorySlot());
            }
        }

        public float CurrentWeight
        {
            get
            {
                float w = fuelSlot.TotalWeight + weaponSlot.TotalWeight + moduleSlot.TotalWeight;
                foreach (var slot in cargoSlots)
                {
                    w += slot.TotalWeight;
                }
                return w;
            }
        }

        public bool AddItem(Item item, int amount)
        {
            if (item == null || amount <= 0) return false;

            switch (item.type)
            {
                case ItemType.Fuel:
                    return AddToSlot(fuelSlot, item, amount);
                case ItemType.Weapon:
                    return AddToSlot(weaponSlot, item, amount);
                case ItemType.Module:
                    return AddToSlot(moduleSlot, item, amount);
            }

            foreach (var slot in cargoSlots)
            {
                if (slot.CanStack(item))
                {
                    slot.quantity += amount;
                    return true;
                }
            }

            foreach (var slot in cargoSlots)
            {
                if (slot.IsEmpty)
                {
                    slot.item = item;
                    slot.quantity = amount;
                    return true;
                }
            }

            return false; // inventory full
        }

        private bool AddToSlot(InventorySlot slot, Item item, int amount)
        {
            if (slot.IsEmpty)
            {
                slot.item = item;
                slot.quantity = amount;
                return true;
            }
            if (slot.CanStack(item))
            {
                slot.quantity += amount;
                return true;
            }
            return false;
        }
    }
}
