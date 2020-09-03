using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ConsumirApiFarmacia.Models
{
    public class BusquedaComuna
    {
        [Required]
        [DisplayName("Nombre de Comuna")]
        public string nombreComuna { get; set; }
    }
}