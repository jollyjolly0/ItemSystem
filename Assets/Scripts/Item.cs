﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace JollyGood.Systems.Item
{
    public struct Item
    {
        readonly public int typeID;

        public Item(int typeID)
        {
            this.typeID = typeID;
        }
    }
}