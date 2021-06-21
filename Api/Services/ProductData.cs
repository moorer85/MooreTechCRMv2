using BlazorApp.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Api.Services
{
    public class ProductData : IProductDataService
    {
        public Task<Product> GetProducts(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
