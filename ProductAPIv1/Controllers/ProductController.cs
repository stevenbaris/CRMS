using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ProductAPI.Data;
using ProductAPI.Model;
using ProductAPI.Repository;

namespace ProductAPI.Controllers
{
    [Authorize]
    [Route("api/v1/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IProductRepository _repo;

        public ProductController(IProductRepository productRepository)
        {
            _repo = productRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetAll()
        {
            // status - http responce
            // ok 200 status code - json 
            return Ok(_repo.GetAllProducts()); // json or xml
        }
    }
}
