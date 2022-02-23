using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using properties.Controllers.Data.Services;

namespace realty.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class pronController : ControllerBase
    {
        public pronatService _pronatService;
        private pronatService _pronatServices;

        public pronController(pronatService pronatService)
        {
            _pronatServices = pronatService;
                
        }

        [HttpGet("get-all-pronat")]

        public IActionResult GetAllPronat()
        {
            var allPronat = _pronatService.GetAllPronat();
            return Ok(allPronat);
        }
    }
}
