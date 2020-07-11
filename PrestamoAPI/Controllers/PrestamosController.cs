using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prestamo_API.Models;
using Prestamo_API.BLL;

namespace PrestamoAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PrestamosController : ControllerBase
    {
        // GET: api/Prestamos
        [HttpGet]
        public ActionResult<List<Prestamos>> Get()
        {
            return PrestamosBLL.GetList();
        }

        // GET api/<PrestamosController>/5
        [HttpGet("{id}")]
        public ActionResult<Prestamos> Get(int id)
        {
            return PrestamosBLL.Buscar(id);
        }

        // POST api/<PrestamosController>
        [HttpPost]
        public void Post([FromBody] Prestamos prestamo)
        {
            PrestamosBLL.Guardar(prestamo);
        }
    }
}
