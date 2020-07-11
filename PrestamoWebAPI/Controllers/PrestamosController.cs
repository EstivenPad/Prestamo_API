using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Prestamo_API.BLL;
using Prestamo_API.Models;

namespace PrestamoWebAPI.Controllers
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

        // GET api/Prestamos/1
        [HttpGet("{id}")]
        public ActionResult<Prestamos> Get(int id)
        {
            return PrestamosBLL.Buscar(id);
        }

        // POST api/Prestamos/
        [HttpPost]
        public void Post([FromBody] Prestamos prestamos)
        {
            PrestamosBLL.Guardar(prestamos);
        }

        // PUT api/Prestamos/
        [HttpPut]
        public void Put([FromBody] Prestamos prestamos)
        {
            PrestamosBLL.Modificar(prestamos);
        }

        // DELETE api/Prestamos/1
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return PrestamosBLL.Eliminar(id);
        }
    }
}
