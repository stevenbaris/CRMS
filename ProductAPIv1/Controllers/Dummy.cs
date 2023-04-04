using Microsoft.AspNetCore.Mvc;
using ProductAPI.Data;
using ProductAPI.Model;

namespace ProductAPI.Controllers
{
    public class Dummy
    {

//        using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using ProductAPI.Data;
//using ProductAPI.Model;

//namespace ProductAPI.Controllers
//    {
//        [Route("api/[controller]")]
//        [ApiController]
//        public class ProductController : ControllerBase
//        {
//            private readonly ProductDbContext _context;

//            public ProductController(ProductDbContext context)
//            {
//                _context = context;
//            }


//            [HttpGet]
//            public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
//            {
//                return await _context.Products.ToListAsync();
//            }

//            // POST: api/Student
//            // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
//            [HttpPost]
//            public async Task<ActionResult<Product>> PostStudent(Product product)
//            {
//                _context.Products.Add(product);
//                await _context.SaveChangesAsync();

//                return CreatedAtAction("GetProduct", new { id = product.Id }, product);
//            }

//        }
//    }


}
}
