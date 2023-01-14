using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventorySlot
{
    public int id { get; set; }
    public int qty { get; set; }
}

public class Inventory
{
    public int id;

    public int maxSlots { get; set; }

    public InventorySlot[] itemList;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="slots"></param>
    public Inventory(int id, int slots)
    {
        this.id = id;
        maxSlots = slots;
        itemList = new InventorySlot[slots];
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="qty"></param>
    /// <returns></returns>
    public void AddItem(int id, int qty)
    {
        for (int i = 0; i < maxSlots; i++)
        {
            if (itemList[i] == null)
            {
                AddItem(id, qty, i);
                break;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="id"></param>
    /// <param name="qty"></param>
    /// <param name="index"></param>
    /// <returns></returns>
    public void AddItem(int id, int qty, int index)
    {
        InventorySlot item = new InventorySlot
        {
            id = id,
            qty = qty
        };

        itemList[index] = item;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="index"></param>
    /// <returns></returns>
    public void RemoveItem(int index)
    {
        itemList[index] = null;
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="index"></param>
    /// <param name="newIndex"></param>
    public void MoveItem(int index, int newIndex)
    {

    }
}
