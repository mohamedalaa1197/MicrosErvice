﻿using Catalog.Entities;
using Catalog.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Catalog.Interfaces
{
    public interface IProductRepository
    {
        void Update(ProductViewModel product, Guid productGuid);
        Task<List<ProductViewModel>> GetProducts();
        Task<ProductViewModel> GetProduct(Guid productGuid);
        void Deleteproduct(Guid productGuid);
        Guid CreatProduct(ProductViewModel product);
        bool Save();
    }
}
