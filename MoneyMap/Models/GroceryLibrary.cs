using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoneyMap.Models
{
    public class GroceryList
    {
        public GroceryItem Item { get; set; }

    }

    public class GroceryItem
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public Type Type { get; set; }

        public GroceryItem()
        {
        }

        public GroceryItem(string name, Type type)
        {
            Id = Guid.NewGuid();
            Name = name;
            Type = type;
        }
    }

    public class GroceryItemPurchase : GroceryItem
    {
        public Decimal Price { get; set; }

        public GroceryItemPurchase(GroceryItem gi, decimal price)
        {
            this.Name = gi.Name;
            this.Type = gi.Type;
            this.Id = Guid.NewGuid();
            Price = price;
        }
    }
    public class GroceryPurchase
    {
        public List<GroceryItemPurchase> GroceryList { get; set; }
        public Client StoreName { get; set; }
        public DateTime PurchaseDate { get; set; }

        public GroceryPurchase(Client storeName, DateTime purchaseDate)
        {
            StoreName = storeName;
            PurchaseDate = purchaseDate;
        }

        public GroceryPurchase(List<GroceryItem> groceryList)
        {
            foreach (var item in groceryList)
            {
                //Call function to retrieve price from user
                Add(item);
            }
        }

        public void Add(GroceryItem newItem, Decimal price = 0)
        {
            GroceryItemPurchase gIP = new GroceryItemPurchase(newItem, price);
            this.GroceryList.Add(gIP);
        }

    }





    public enum Type
    {
        Vegetable, Fruit, Grain, Pasta, Treat, Bread, BakedGood, Meat, Seafood, Condiment, NonFood
    }

}