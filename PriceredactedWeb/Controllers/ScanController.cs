using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PriceredactedWeb.Models;
using Priceredacted.Interfaces;
using System.Drawing;



namespace PriceredactedWeb.Controllers
{
    [Route("/api/[controller]")]
    [ApiController]
    public class ScanPageController : ControllerBase
    {
        private readonly PriceredactedDBContext _context;
        IScanPageLogic _scanPageLogic;

        public ScanPageController(IScanPageLogic scanPageLogic, PriceredactedDBContext context){
            _scanPageLogic = scanPageLogic;
            _context = context;
        }

        [HttpPost("Scan")]
        public async Task<ActionResult<IEnumerable<Priceredacted.Properties.ScannedProduct>>> ScanReceipt([FromBody] ImageStringDTO imageString){

            Bitmap image = (Bitmap)Image.FromStream(new MemoryStream(Convert.FromBase64String(imageString.ImageString)));

            string scannedText = await _scanPageLogic.ScanImageAsync(image);

            if (scannedText == null)
            {
                return NoContent();
            }
            else
            {
                return await _scanPageLogic.FilterText(scannedText);
            }
        }
        [HttpPost("Compare")]
        public async Task<ActionResult<IEnumerable<Priceredacted.Properties.ComparedProduct>>> ComparePrices(
            [FromBody] List<Priceredacted.Properties.ScannedProduct> products){

            if (products.Count == 0)
            {
                return NoContent();
            }
            else
            {
                return await _scanPageLogic.ComparePrices(products);
            }
        }


        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        { 
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {   
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {  
        }
    }

    // [Route("api/[controller]")]
    // [ApiController]
    // public class ScanController : ControllerBase
    // {
    //     [HttpGet("scan")]
    //     public async Task<ActionResult<UserDatum>> Get(){
    //         UserDatum user = new UserDatum{ Username = "USERIS1", 
    //         Email = "NewEmail",
    //         Password = "BestPassword", 
    //         Id = "13163541-65416-6544"};
    //         return await Task.Run(() => user);
    //     }
    // }
    // //     // GET: api/Products
    // //     [HttpGet]
    // //     public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
    // //     {
    // //         return await _context.Products.ToListAsync();
    // //     }

    // //     // GET: api/Products/5
    // //     [HttpGet("{id}")]
    // //     public async Task<ActionResult<Product>> GetProduct(string id)
    // //     {
    // //         var product = await _context.Products.FindAsync(id);

    // //         if (product == null)
    // //         {
    // //             return NotFound();
    // //         }

    // //         return product;
    // //     }

    // //     // PUT: api/Products/5
    // //     // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    // //     [HttpPut("{id}")]
    // //     public async Task<IActionResult> PutProduct(string id, Product product)
    // //     {
    // //         if (id != product.Name)
    // //         {
    // //             return BadRequest();
    // //         }

    // //         _context.Entry(product).State = EntityState.Modified;

    // //         try
    // //         {
    // //             await _context.SaveChangesAsync();
    // //         }
    // //         catch (DbUpdateConcurrencyException)
    // //         {
    // //             if (!ProductExists(id))
    // //             {
    // //                 return NotFound();
    // //             }
    // //             else
    // //             {
    // //                 throw;
    // //             }
    // //         }

    // //         return NoContent();
    // //     }

    // //     // POST: api/Products
    // //     // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
    // //     [HttpPost]
    // //     public async Task<ActionResult<Product>> PostProduct(Product product)
    // //     {
    // //         _context.Products.Add(product);
    // //         try
    // //         {
    // //             await _context.SaveChangesAsync();
    // //         }
    // //         catch (DbUpdateException)
    // //         {
    // //             if (ProductExists(product.Name))
    // //             {
    // //                 return Conflict();
    // //             }
    // //             else
    // //             {
    // //                 throw;
    // //             }
    // //         }

    // //         return CreatedAtAction("GetProduct", new { id = product.Name }, product);
    // //     }

    // //     // DELETE: api/Products/5
    // //     [HttpDelete("{id}")]
    // //     public async Task<IActionResult> DeleteProduct(string id)
    // //     {
    // //         var product = await _context.Products.FindAsync(id);
    // //         if (product == null)
    // //         {
    // //             return NotFound();
    // //         }

    // //         _context.Products.Remove(product);
    // //         await _context.SaveChangesAsync();

    // //         return NoContent();
    // //     }

    // //     private bool ProductExists(string id)
    // //     {
    // //         return _context.Products.Any(e => e.Name == id);
    // //     }
    // // }
}
