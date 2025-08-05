/*
 * SPDX-FileCopyrightText: 2024 Espressif Systems (Shanghai) CO LTD
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using UnityEngine;

namespace UnityInventory
{
    public enum ItemType
    {
        Fuel,
        Ammo,
        Resource,
        Weapon,
        Module
    }

    [CreateAssetMenu(menuName = "UnityInventory/Item")]
    public class Item : ScriptableObject
    {
        public string itemName;
        [TextArea] public string description;
        public Sprite icon;
        public ItemType type;
        public float weight;
        public int value;
        public bool stackable;
    }
}
