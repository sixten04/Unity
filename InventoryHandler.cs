using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

[Serializable]
public class Item
{
    public int id;
    public string name;
    public string description;
    public double weight;
    public string sprite;
}

[Serializable]
public class ItemList
{
    public List<Item> items;
}

public class InventoryHandler
{
    public ItemList masterItemList = null;

    public InventoryHandler()
    {
        string itemFilePath = "C:\\Users\\Mike\\Workspaces\\Unity\\Inventory Module\\Inventory Module\\Assets\\Data\\items.json";
        ItemList masterItemList = new ItemList();

        try
        {
            if (!File.Exists(itemFilePath))
                throw new FileNotFoundException("Could not find the item file.");

            using (StreamReader r = new StreamReader(itemFilePath))
            {
                string json = r.ReadToEnd();
                masterItemList = JsonUtility.FromJson<ItemList>(json);
            }
        }catch(Exception e)
        {
            Console.WriteLine(e.Message);
            throw e;
        }
    }
}
