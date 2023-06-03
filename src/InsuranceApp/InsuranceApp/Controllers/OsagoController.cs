using InsuranceApp.Osago;
using InsuranceApp.Osago.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InsuranceApp.Controllers
{
    [Route("api/osago")]
    [ApiController]
    public class OsagoController : ControllerBase
    {
        private readonly OsagoContext _context;

        public OsagoController(OsagoContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<JsonResult> GetPolicy(int id)
        {
            if (id == default)
                throw new BadHttpRequestException("id cannot be zero");

            var policy = await _context.OsagoPolicies.SingleOrDefaultAsync(x => x.Id == id);

            return new JsonResult(policy);
        }

        [HttpPost]
        public async Task<JsonResult> CreatePolicy()
        {
            var policy = new OsagoPolicy(PolicyState.Draft);

            _context.OsagoPolicies.Add(policy);

            await _context.SaveChangesAsync();

            return new JsonResult(policy);
        }
    }
}
