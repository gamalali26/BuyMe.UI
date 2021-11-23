﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuyMe.Application.Common.Models
{
    public class CustomCategoryModel
    {
        public const string Product = "Product";
        public const string Warehouse = "Warehouse";
        public const string CustomerType = "CustomerType";
        public const string Customer = "Customer";
        public const string SalesType = "SalesType";
        public const string SalesOrder = "SalesOrder";
        public const string Category = "Category";
        public const string UnitOfMeasure = "UnitOfMeasure";
        public const string Currency = "Currency";
        public const string Branch = "Branch";
        public const string Template = "Template";
        public const string Settings = "Settings";
        public const string User = "User";
        public const string ChangeRole = "ChangeRole";
        public const string ShipmentType = "ShipmentType";
        public const string Shipment = "Shipment";
        public static IEnumerable<string> GetCustomCategories()
        {
            return typeof(CustomCategoryModel).GetFields().Select(a => a.Name);
        }
    }
}
