using System;
using System.Collections.Generic;
using System.Text;

namespace Prius_Service
{
    public class Item
    {
        private string name;
        private string itemNumber;
        private string manufacturer;
        private string barcode;
        private int quantity;
        private int minQuantity;
        private int costPrice;
        private int sellPrice;

        public Item(string name, string itemNumber, string manufacturer, string barcode, int quantity, int minQuantity, int costPrice, int sellPrice)
        {
            this.Name = name;
            this.ItemNumber = itemNumber;
            this.Manufacturer = manufacturer;
            this.Barcode = barcode;
            this.Quantity = quantity;
            this.MinQuantity = minQuantity;
            this.CostPrice = costPrice;
            this.SellPrice = sellPrice;
        }

        public string Name { get => name; set => name = value; }
        public string ItemNumber { get => itemNumber; set => itemNumber = value; }
        public string Manufacturer { get => manufacturer; set => manufacturer = value; }
        public string Barcode { get => barcode; set => barcode = value; }
        public int Quantity { get => quantity; set => quantity = value; }
        public int MinQuantity { get => minQuantity; set => minQuantity = value; }
        public int CostPrice { get => costPrice; set => costPrice = value; }
        public int SellPrice { get => sellPrice; set => sellPrice = value; }
    }
}
