using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class InventoryTest
{
    [Test]
    public void Constructor_id_slots()
    {
        int id = 10;
        int slots = 12;

        Inventory testInventory = new Inventory(id, slots);
        Assert.IsTrue(testInventory.id == 10);
        Assert.IsTrue(testInventory.maxSlots == slots);
        Assert.IsTrue(testInventory.itemList != null);
    }

    [Test]
    public void AddItem_Empty()
    {
        int id;
        int slots;
        Inventory testInventory;

        id = 3;
        slots = 4;
        testInventory = new Inventory(id, slots);

        testInventory.AddItem(0, 1);
        Assert.IsTrue(testInventory.itemList[0] != null);
        Assert.IsTrue(testInventory.itemList[0].id == 0);      
    }

    [Test]
    public void AddItem_Full()
    {
        int id;
        int slots;
        Inventory testInventory;

        id = 1;
        slots = 4;
        testInventory = new Inventory(id, slots);

        for(int i = 0; i < slots; i++)
            testInventory.AddItem(0, 1);

        for(int i = 0; i < slots; i++)
        {
            Assert.IsTrue(testInventory.itemList[i] != null);
        }

        testInventory.AddItem(1, 1);
        bool foundItem = false;

        for (int i = 0; i < slots; i++)
        {
            if (testInventory.itemList[i].id == 1)
                foundItem = true;
        }

        Assert.IsTrue(foundItem == false);
    }
}
