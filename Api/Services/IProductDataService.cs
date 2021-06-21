using BlazorApp.Shared;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp.Api.Services
{
    public interface IProductDataService
    {

        Task<Product> GetProducts(int Id);
    }
}
