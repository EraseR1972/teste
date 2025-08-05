/*
 * SPDX-FileCopyrightText: 2024 Espressif Systems (Shanghai) CO LTD
 *
 * SPDX-License-Identifier: Apache-2.0
 */

using UnityEngine;
using UnityEngine.UI;

namespace UnityInventory
{
    public class TooltipUI : MonoBehaviour
    {
        public GameObject root;
        public Text nameText;
        public Text descriptionText;
        public Text weightText;
        public Text valueText;
        public Text quantityText;

        public void Show(Item item, int quantity)
        {
            if (item == null || root == null) return;
            root.SetActive(true);
            nameText.text = item.itemName;
            descriptionText.text = item.description;
            weightText.text = $"Weight: {item.weight * quantity:0.##}";
            valueText.text = $"Value: {item.value}";
            quantityText.text = $"Qty: {quantity}";
        }

        public void Hide()
        {
            if (root != null)
            {
                root.SetActive(false);
            }
        }
    }
}
