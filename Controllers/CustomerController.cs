using ex_odata.Services;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;

namespace ex_odata.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;
        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet(nameof(GetData))]
        [EnableQuery]
        public IActionResult GetData() => Ok(_customerService.GetCustomers());
    }
}
