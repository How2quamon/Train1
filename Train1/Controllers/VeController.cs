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
        
        [HttpPost]
        public IActionResult CreateNew(VeViewModel model)
        {
            try
            {
                var Ve = new Ve
                {
                    MaVe = model.MaVe,
                    MaGhe = model.MaGhe,
                    MaKhachHang = model.MaKhachHang,
                    MaNhanVien = model.MaNhanVien,
                    GiaVe = model.GiaVe
                };
                _context.Add(Ve);
                _context.SaveChanges();
                return Ok(Ve);
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpPut("{id}")]
        public IActionResult UpdateVeById(Guid id, VeViewModel model)
        {
            var Ve = _context.Ves.SingleOrDefault(v => v.MaVe == id);
            if (Ve != null)
            {
                Ve.MaGhe = model.MaGhe;
                Ve.MaKhachHang = model.MaKhachHang;
                Ve.MaNhanVien = model.MaNhanVien;
                Ve.GiaVe = model.GiaVe;
                _context.SaveChanges();
                return NoContent();
            }
            else
            {
                return NotFound();
            }
        }
    }
}
