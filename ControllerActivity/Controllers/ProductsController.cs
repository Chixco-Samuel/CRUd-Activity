using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ControllerActivity.Controllers.Models;
namespace ControllerActivity.Controllers
{
    [Route("Production")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public static List<Product> products = new List<Product>();

        public ProductsController()
        {

        }

        [HttpGet]
        public List<Product> GetProduct()
        {
            return products;
        }

        [HttpGet("{id}")]
        public ActionResult<Product> GetProduct(int id)
        {
            var product = products.Where(p => p.ProductId == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        [HttpPost]
        public ActionResult AddPerson(Product product)
        {
            products.Add(product);
            return Created();
        }

        [HttpPut("{id}")]
        public ActionResult<Product> EditPerson(int id, Product newproduct)
        {
            var product = products.Where(m => m.Id == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            product = newproduct;
            return Ok();
        }

        [HttpDelete("{id}")]
        public ActionResult DeletePerson(int id)
        {
            var product = products.Where(m => m.Id == id).FirstOrDefault();
            if (product == null)
            {
                return NotFound();
            }
            products.Remove(product);
            return Ok();
        }
    }
}