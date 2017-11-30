﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.Entities.Sales.Api;

namespace Company.Entities.Sales.Associate
{
    class SmallOrder : IOrder
    {
        private List<string> _products = new List<string>();
        private decimal _unitPrice;
        public string OrderId { get; private set; }

        public SmallOrder(decimal unitPrice)
        {
            OrderId = new Guid().ToString();
            _unitPrice = unitPrice;
        }

        public List<string> GetProducts()
        {
            return _products;
        }

        public int GetQuantity()
        {
            return _products.Count;
        }

        public decimal GetTotalPrice()
        {
            return _unitPrice * GetQuantity();
        }
        
        public decimal GetUnitPrice()
        {
            return _unitPrice;
        }

        public void AddProduct(string productId)
        {
            _products.Add(productId);
        }
    }
}