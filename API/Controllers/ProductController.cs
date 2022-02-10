using DataService.DTOs;
using DataService.DTOS;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace API.Controllers
{
    [Route("[Controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {

        DataService.ProductService productService = new DataService.ProductService();
        DataService.DepartmentService departmentService = new DataService.DepartmentService();


        //För G - Skriv ut en lista med ProductName samt ProductCount, den ska vara sorterad enligt ProductCount med lägst antal först
        //För VG - skriv ut ProductStatus, antal > 3 = OK, antal =< 3 && antal > 0 = Snart slut, antal < 1 = Slut

        [HttpGet("Count")] //KLAR OCH FUNGERAR
        public List<ProductStatusDTO> GetProductCount()
        {
            return productService.GetProductsCountAndStatus().OrderBy(x => x.ProductCount).ToList();
        }

        //För G - Ta emot information om vilken produkt som ska uppdateras och med vilket antal,
        //uppdatera producten och retunera ProductName samt ProductCount

        [HttpPost("Update")] //KLAR OCH FUNGERAR
        public ProductCountDTO UpdateProduct([FromBody] UpdateProductDTO updateProductDTO)
        {
            return productService.UpdateProduct(updateProductDTO);
        }


        //För VG - Lista namnet på produkter i en viss avdelning och som har ett visst antal eller mindre kvar,
        //Ta emot två query-parametrar, Department och count, inkludera även de produkter med samma värde som count

        [HttpGet("List")] //KLAR OCH FUNGERAR
        public List<ProductCountDTO> GetProductsInDepartmentCount([FromQuery] string departmentName, [FromQuery] int count)
        {
            return productService.GetProductsInDepartments(departmentName, count).OrderBy(x => x.ProductCount).ToList();
        }
    }
}
