using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Simple_WebVending.Models
{
    public class ItemRegistration
    {
        List<VendingItems> ItemList;
        static ItemRegistration items = null;
        private ItemRegistration()
        {
            ItemList = new List<VendingItems>();
        }
        public static ItemRegistration GetInstance()
        {
            if (items == null)
            {
                items = new ItemRegistration();
                return items;
            }
            else
            {
                return items;
            }
        }
        public void Add(VendingItems item)
        {
            ItemList.Add(item);
        }
        public String Remove(String registrationNumber)
        {
            for (int i = 0; i < ItemList.Count; i++)
            {
                VendingItems itemn = ItemList.ElementAt(i);
                if (itemn.RegistrationNumber.Equals(registrationNumber))
                {
                    ItemList.RemoveAt(i);//update the new record
                    return "Delete successful";
                }
            }
            return "Item not found";
        }
        public List<VendingItems> GetAllItems()
        {
            return ItemList;
        }
        public String RemoveAllItems()
        {
            ItemList = new List<VendingItems>();
            return "Vending machine successful cleaned";
        }
        public VendingItems GetItems(String registrationNumber)
        {
            for (int i = 0; i < ItemList.Count; i++)
            {
                VendingItems itemn = ItemList.ElementAt(i);
                if (itemn.RegistrationNumber.Equals(registrationNumber))
                {
                    return itemn;
                }
            }
            return null;
        }
        public String UpdateItem(VendingItems items)
        {
            for (int i = 0; i < ItemList.Count; i++)
            {
                VendingItems itemn = ItemList.ElementAt(i);
                if (itemn.RegistrationNumber.Equals(items.RegistrationNumber))
                {
                    ItemList[i] = items;//update the new record
                    return "Update successful";
                }
            }
            return "Item Not Found";
        }
    }
}