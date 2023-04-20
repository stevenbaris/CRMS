using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Data;
using ProductAPI.DTO;
using ProductAPI.Model;
using ProductAPI.Repository;

namespace ProductAPI.Controllers
{
    [Authorize]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductRepository _productRepo;

        public ProductController(IProductRepository productRepository)
        {
            _productRepo = productRepository;
        }

        [HttpGet("ProductList")]
        public async Task<ActionResult> GetAllProducts()
        {
            try
            {
                var products = await _productRepo.GetAllAsync();
                return Ok(products);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error retrieving products: {ex.Message}");
            }
        }

        [HttpGet("GetProduct/{id}")]
        public async Task<ActionResult<Product>> GetProductById(Guid id)
        {
            try
            {
                var product = await _productRepo.GetbyIdAsync(id);
                if (product == null) { 
                    return NotFound();
                }
                return Ok(product);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error retrieving product: {ex.Message}");
            }
        }

        [HttpPost("Create")]
        public async Task<ActionResult<Product>> CreateProducts([FromBody] ProductDTO productDto)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                var newProduct = new Product
                {
                    Product_Id = Guid.NewGuid(),
                    ProductName = productDto.ProductName,
                    ProductDescription = productDto.ProductDescription,
                    Benefits = productDto.Benefits,
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now
                };
               
                var createdProduct = await _productRepo.CreateAsync(newProduct);
                return CreatedAtAction(nameof(GetProductById), new { id = createdProduct.Product_Id }, createdProduct);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error creating product: {ex.Message}");
            }
        }


        [HttpPut("UpdateProduct/{id}")]
        public async Task<IActionResult> Update(Guid id, [FromBody] ProductDTO productDto)
        {
            try
            {
                var existingProduct = await _productRepo.GetbyIdAsync(id);
                if (existingProduct == null) { 
                    return NotFound();
                }
                existingProduct.ProductName= productDto.ProductName;
                existingProduct.ProductDescription = productDto.ProductDescription;
                existingProduct.Benefits = productDto.ProductDescription;
                existingProduct.UpdateDate = DateTime.Now;
                await _productRepo.UpdateAsync(existingProduct);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error updating product: {ex.Message}");
            }
        }

        [HttpDelete("DeleteProduct/{id}")]
        public async Task<IActionResult> DeleteProduct(Guid id)
        {
            try
            {
                var existingProduct = await _productRepo.GetbyIdAsync(id);
                if (existingProduct == null) { 
                    return NotFound();
                }
                await _productRepo.DeleteAsync(existingProduct.Product_Id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, $"Error deleting product: {ex.Message}");
            }
        }


    }
}
