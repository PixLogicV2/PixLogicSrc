﻿using System;
using System.Drawing;
using System.IO;

namespace PixLogic.DAL
{
    public class ItemFactory
    {
        public Item build(string name, string description, bool dispo, int price, Image image, string reference, int quantity)
        {
            Item item = new Item();
            item.name=name;
            item.description = description;
            item.dispo = dispo;
            item.price = price;
            if (image != null) item.image = Helper.imageToByteArray(image);
            else item.image = null;
            item.reference = reference;
            item.quantity=quantity;
            item.isPack = false;
            item.temp = false;

            return item;
        }
    }
}
