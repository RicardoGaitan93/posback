using Microsoft.AspNetCore.Mvc;
using Pos.Api.Application.Contracts.Services;
using Pos.Api.Business.Models;
using Pos.Api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Pos.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;


        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet("{id}")]
        public async Task<ActionResult> Get(int id)
        {
            Product product = await _productService.GetProductById(id);
            return Ok(product);
        }
        //[HttpGet("GetAllProducts")]
        //public async Task<ActionResult> GetAllProducts()
        //{
        //    List<Product> products = await _productService.GetAllProducts();
        //    return Ok(products);
        //}

        [HttpGet("GetAllProducts")]
        public async Task<ActionResult<ApiResponse>> GetAllProducts()
        {
            ApiResponse _apiResponse = new ApiResponse();
            try
            {

                List<Product> products = await _productService.GetAllProducts();
                _apiResponse.Result = true;
                _apiResponse.Message = "OK";
                _apiResponse.Payload.Add("Data", products);

                return Ok(_apiResponse);

            }
            catch (Exception ex)
            {
                _apiResponse.Result = false;
                _apiResponse.Message = ex.Message.ToString();

                return StatusCode(500, _apiResponse);
            }


        }
        [HttpPost("CreateProduct")]
        public async Task<ActionResult<ApiResponse>> CreateProduct([FromBody]Product product)
        {
            ApiResponse _apiResponse = new ApiResponse();
            try
            {
                var created = await _productService.CreateNewProduct(product);
            }
            catch (Exception ex)
            {

            }

            return Ok();
        }

        [HttpPut("UpdateProduct")]
        public async Task<ActionResult<ApiResponse>> UpdateProduct([FromBody]Product product)
        {
            ApiResponse _apiResponse = new ApiResponse();
            try
            {
                var updated = await _productService.UpdateProduct(product);

                if (updated =="1")
                {
                    _apiResponse.Result = true;
                    _apiResponse.Message = "OK";
                    _apiResponse.Payload.Add("Data", updated);
                }
                else
                {
                    _apiResponse.Result = false;
                    _apiResponse.Message = "Error";
                    _apiResponse.Payload.Add("Data", updated);
                }


                return Ok(_apiResponse);

            }
            catch (Exception ex)
            {
                _apiResponse.Result = false;
                _apiResponse.Message = ex.Message.ToString();
                return StatusCode(500, _apiResponse);
            }
        }

        [HttpDelete]
        public async Task<ActionResult<ApiResponse>> DeleteProduct()
        {

            return Ok();
        }

    }
}
