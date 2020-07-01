using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Prestamo_API.Models
{
    public class Prestamos
    {
        [Key]
        public int PrestamoId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir una fecha")]
        public DateTime Fecha { get; set; }

        public int PersonaId { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir un concepto")]
        public string Concepto { get; set; }

        [Required(ErrorMessage = "Es obligatorio introducir un monto")]
        public double Monto { get; set; }

        public double Balance { get; set; }
    }
}
