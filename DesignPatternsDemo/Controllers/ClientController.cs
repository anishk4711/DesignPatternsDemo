using DesignPatternsDemo.BuilderDP;
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

        [HttpGet("GetCustomer")]
        public ActionResult<Customer> Get()
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
    }
}
