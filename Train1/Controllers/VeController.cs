using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Train1.Data;
using Train1.Models;

namespace Train1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VeController : ControllerBase
    {
        private readonly CTQM_DbContext _context;

        public VeController(CTQM_DbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var dsVe = _context.Ves.ToList();
            return Ok(dsVe);
        }
        [HttpGet("{id}")]
        public IActionResult GetById(Guid id)
        {
            var Ve = _context.Ves.SingleOrDefault(v => v.MaVe == id);
            if (Ve != null)
            {
                return Ok(Ve);
            }
            else
            {
                return NotFound();
            }
        }
        /*
                [HttpPost]
                public IActionResult CreateNew(VeViewModel model)
                {
                    var Ve = new Ve
                    {

                    };
                    _context.Add(model);
                    _context.SaveChanges();

                }
        */
    }
}
