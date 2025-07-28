using DesignPatternsDemo.BuilderDP;
using DesignPatternsDemo.PrototypeDP;
using Microsoft.AspNetCore.Mvc;

namespace DesignPatternsDemo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientController : ControllerBase
    {

        private readonly ILogger<ClientController> _logger;

        public ClientController(ILogger<ClientController> logger)
        {
            _logger = logger;
        }

        [HttpGet("BuilderDP")]
        public ActionResult<Customer> GetCustomer()
        {
            return
                CustomerBuilder.CreateCustomerBuilder()
                 .SetName("Anish")
                 .SetEmail("anishkumar.vns@gmail.com")
                 .SetPhone("1234567890")
                 .SetBillingAddress(ab => ab.SetCity("Bangalore")
                     .SetState("Karnataka")
                     .SetStreet("123 Main St")
                     .SetZipCode("560001"))
                 .Build();
        }


        [HttpGet("PrototypeDP")]
        public ActionResult<Product> GetProduct()
        {
            Product originalProd = new Product
            {
                Name = "Laptop",
                Price = 1200.00m,
                Description = "High performance laptop",
                Category = "Electronics",
                InventoryLocation = new Location
                { 
                    Warehouse = "Bangalore",
                    Shelf = "560002"
                }
            };


            Product clonedProd = originalProd.Clone();

            return clonedProd;
        }
    }
}
