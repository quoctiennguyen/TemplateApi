   using Microsoft.AspNetCore.Mvc;
   using System.Collections.Generic;
   using System.Threading.Tasks;
   using TemplateApi.Models;
   using TemplateApi.Services;

   namespace TemplateApi.Controllers
   {
       [Route("api/[controller]")]
       [ApiController]
       public class ProductsController : ControllerBase
       {
           private readonly IProductService _productService;

           public ProductsController(IProductService productService)
           {
               _productService = productService;
           }

           [HttpGet]
           public async Task<ActionResult<IEnumerable<Product>>> GetProducts()
           {
               var products = await _productService.GetAllAsync();
               return Ok(products);
           }

           [HttpGet("{id}")]
           public async Task<ActionResult<Product>> GetProduct(int id)
           {
               var product = await _productService.GetByIdAsync(id);
               if (product == null)
               {
                   return NotFound();
               }
               return Ok(product);
           }

           [HttpPost]
           public async Task<ActionResult> PostProduct(Product product)
           {
               await _productService.AddAsync(product);
               return CreatedAtAction(nameof(GetProduct), new { id = product.Id }, product);
           }

           [HttpPut("{id}")]
           public async Task<IActionResult> PutProduct(int id, Product product)
           {
               if (id != product.Id)
               {
                   return BadRequest();
               }

               await _productService.UpdateAsync(product);
               return NoContent();
           }

           [HttpDelete("{id}")]
           public async Task<IActionResult> DeleteProduct(int id)
           {
               await _productService.DeleteAsync(id);
               return NoContent();
           }
       }
   }
   