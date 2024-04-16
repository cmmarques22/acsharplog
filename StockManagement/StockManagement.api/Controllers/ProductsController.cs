using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StockManagement.api.DTOs;
using StockManagement.api.Models;

namespace StockManagement.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly StockManagementContext _context;

        public ProductsController(StockManagementContext context)
        {
            _context = context;
        }

        // GET: api/Products
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProducts()
        {
            List<ProductDTO> list = new List<ProductDTO>();
            var products = await _context.Products.Include(p => p.Family).ToListAsync();
            foreach (var product in products)
            {
                list.Add(new ProductDTO().ProductModelToDto(product));
            }

            return list;
        }

        // GET: api/Products/5
        [HttpGet("{familyId}/GetProductByFamily")]
        public async Task<ActionResult<IEnumerable<ProductDTO>>> GetProductByFamily(string familyid)

        {
            List<ProductDTO> list = new List<ProductDTO>();

            var products = await _context.Products.Include(p => p.Family).Where(p => p.FamilyId == familyid).ToListAsync();

            foreach (var product in products)
            {
                list.Add(new ProductDTO().ProductModelToDto(product));

            }
            return list;
        }

        // GET: api/Products/5
        [HttpGet("{id}")]
        public async Task<ActionResult<ProductDTO>> GetProductbyId(string id)
        {
            var product = await _context.Products.Include(p => p.Family).Where(p => p.ProductId == id).ToListAsync();


            if (product == null)
            {
                return NotFound();
            }

            return new ProductDTO().ProductModelToDto(product.First());
        }


        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct(string id, ProductDTO product)
        {
            if (id != product.ProductId)
            {
                return BadRequest();
            }
            if (!ProductExists(id))
            {
                return NotFound();
            }

            var family = await _context.Families.FindAsync(product.FamilyId);

            _context.Entry(product).State = EntityState.Modified;

            if (family == null)
            {
                return NotFound(family);
            }

            Product productModel = product.DtoToProductModel();
            _context.Entry(productModel).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return Ok();
        }

        

        // POST: api/Products
        [HttpPost]
        public async Task<ActionResult<ProductDTO>> CreateProduct(ProductDTO product)
        {
            List<ProductDTO> list = new List<ProductDTO>();
            var family = await _context.Families.FindAsync(product.FamilyId);
            if (family != null)
            {
                return NotFound(family);
            }

            Product productModel = product.DtoToProductModel();
            productModel.Family = family;
            _context.Products.Add(productModel);

            await _context.SaveChangesAsync();
            return Ok();
        }

        // DELETE: api/Products/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct(string id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null)
            {
                return NotFound();
            }

            _context.Products.Remove(product);
            await _context.SaveChangesAsync();

            return Ok();
        }


        private bool ProductExists(string id)
        {
            return _context.Products.Any(e => e.ProductId == id);
        }
    }
}
