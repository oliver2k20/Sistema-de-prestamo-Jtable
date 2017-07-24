using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Jey.Entities
{
    public class prestamos
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Amount { get; set; }
        public int Percentage { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechadelPrestamo { get; set; }
    }
}