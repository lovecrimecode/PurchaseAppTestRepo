﻿using System.Collections.Generic;
using PurchaseApp.Domain;

namespace PurchaseApp.Data
{
    public interface IProductRepository
    {
        IEnumerable<Product> GetAllProducts();
        Product GetProductById(int id);
        void AddProduct(Product product);
        void UpdateProduct(Product product);
        void DeleteProduct(int id);
    }
}
