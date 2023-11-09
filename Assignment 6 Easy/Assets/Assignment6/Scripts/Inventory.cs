/*
* Denver Heneghan
* Inventory
* Assignment 6 Easy
* This script calls the information from the script InventoryItem. This script accesses the serialized field from the InventoryItem script.
* It takes the information and puts it into a list.
*/

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Inventory : MonoBehaviour
{
    [SerializeField] private InventoryItem item;

    public List<InventoryItem> inventory;

    void Start()
    {
        item = new InventoryItem();

        inventory = new List<InventoryItem>();
    }
}
