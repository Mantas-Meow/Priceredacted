using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PriceredactedWeb.Models;

namespace PriceredactedWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SearchController : ControllerBase
    {
        private readonly PriceredactedDBContext _context;

        public SearchController(PriceredactedDBContext context)
        {
            _context = context;
        }

        

        // // GET: api/Products
        [HttpPost]
        public async Task<ActionResult<IEnumerable<Product>>> GetProducts([FromBody] SearchParamsDTO param)
        {
            List<Product> products = new List<Product>();
            products.Add(
                new Product(){
                    Shop = param.Shop,
                    ItemGroup = param.ItemGroup,
                    Name = param.Name,
                    PriceUnit = param.PriceUnit,
                    Price = param.Price}
                    );

            return products;
            //return await _context.Products.ToListAsync();
        }

        // // GET: api/Products/5
        // [HttpGet("{id}")]
        // public async Task<ActionResult<Product>> GetProduct(string id)
        // {
        //     var product = await _context.Products.FindAsync(id);

        //     if (product == null)
        //     {
        //         return NotFound();
        //     }

        //     return product;
        // }

        // // PUT: api/Products/5
        // // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // [HttpPut("{id}")]
        // public async Task<IActionResult> PutProduct(string id, Product product)
        // {
        //     if (id != product.Name)
        //     {
        //         return BadRequest();
        //     }

        //     _context.Entry(product).State = EntityState.Modified;

        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateConcurrencyException)
        //     {
        //         if (!ProductExists(id))
        //         {
        //             return NotFound();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return NoContent();
        // }

        // // POST: api/Products
        // // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        // [HttpPost]
        // public async Task<ActionResult<Product>> PostProduct(Product product)
        // {
        //     _context.Products.Add(product);
        //     try
        //     {
        //         await _context.SaveChangesAsync();
        //     }
        //     catch (DbUpdateException)
        //     {
        //         if (ProductExists(product.Name))
        //         {
        //             return Conflict();
        //         }
        //         else
        //         {
        //             throw;
        //         }
        //     }

        //     return CreatedAtAction("GetProduct", new { id = product.Name }, product);
        // }

        // // DELETE: api/Products/5
        // [HttpDelete("{id}")]
        // public async Task<IActionResult> DeleteProduct(string id)
        // {
        //     var product = await _context.Products.FindAsync(id);
        //     if (product == null)
        //     {
        //         return NotFound();
        //     }

        //     _context.Products.Remove(product);
        //     await _context.SaveChangesAsync();

        //     return NoContent();
        // }

        // private bool ProductExists(string id)
        // {
        //     return _context.Products.Any(e => e.Name == id);
        // }
    }
}
