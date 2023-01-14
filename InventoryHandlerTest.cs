using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class InventoryHandlerTest
{
    // A Test behaves as an ordinary method
    [Test]
    public void CanInitialize()
    {
        InventoryHandler handler = new InventoryHandler();

        Assert.IsNotNull(handler.masterItemList);  
    }
}
