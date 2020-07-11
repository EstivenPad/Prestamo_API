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
    public class PersonasController : ControllerBase
    {
        // GET: api/Personas
        [HttpGet]
        public ActionResult<List<Personas>> Get()
        {
            return PersonasBLL.GetList();
        }

        // GET api/Personas/1
        [HttpGet("{id}")]
        public ActionResult<Personas> Get(int id)
        {
            return PersonasBLL.Buscar(id);
        }

        // POST api/Personas/
        [HttpPost]
        public void Post([FromBody] Personas persona)
        {
            PersonasBLL.Guardar(persona);
        }

        // PUT api/Personas/
        [HttpPut]
        public void Put([FromBody] Personas persona)
        {
            PersonasBLL.Modificar(persona);
        }

        // DELETE api/Personas/1
        [HttpDelete("{id}")]
        public bool Delete(int id)
        {
            return PersonasBLL.Eliminar(id);
        }
    }
}
