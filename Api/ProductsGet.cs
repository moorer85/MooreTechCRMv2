using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using BlazorApp.Api.Services;

namespace BlazorApp.Api
{
    public class ProductsGet
    {
        private readonly IProductDataService productData;

        public ProductsGet(IProductDataService productData)
        {
            this.productData = productData;
        }

        [FunctionName("ProductsGet")]
        public async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "product")] HttpRequest req)
        {
            var products = await productData.GetProducts(4);
            return new OkObjectResult(products);
        }
    }
}