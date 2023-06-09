﻿using API_Blossom1.IServices;
using Entities.Entities;
using Entities.SearchFilter;
using Microsoft.AspNetCore.Mvc;
using System.Web.Http.Cors;

namespace API_Blossom1.Controllers

{

    [EnableCors(origins: "*", headers: "*", methods: "*")]

    [Route("[controller]/[action]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;
        private readonly IProductService _productService;
        public ProductController(ILogger<ProductController> logger, IProductService productService)
        {
            _logger = logger;
            _productService = productService;
        }

        [HttpPost(Name = "InsertProduct")]
        public int Post([FromBody] ProductItem productItem)
        {
            return _productService.InsertProduct(productItem);
        }

        [HttpGet(Name = "GetProducts")]
        public List<ProductItem> GetProduct()
        {
            return _productService.GetProduct();
        }

        [HttpGet(Name = "GetProductsByCriteria")]
        public List<ProductItem> GetByCriteria(bool isActive)
        {
            var productFilter = new ProductFilter();
            productFilter.IsActive = isActive;
            return _productService.GetProductsByCriteria(productFilter);
        }

        [HttpDelete(Name = "DeleteProduct")]

        public void DeleteProductItem([FromQuery] int id)
        {
            _productService.DeleteProductItem(id);
        }

        [HttpPatch(Name = "ModifyProduct")]
        public void Patch([FromBody] ProductItem productItem)
        {
            _productService.UpdateProduct(productItem);
        }
    }

}


