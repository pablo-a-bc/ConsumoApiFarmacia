using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /// <summary>
    /// Estructura de datos que se obtienen de las farmacias de turno.
    /// Los nombres de las propiedades están como las envía el Json de respuesta de la API Rest.
    /// </summary>
    public class Farmacia
    {
        [DisplayName("Fecha")]
        public string fecha { get; set; }
        [DisplayName("Id")]
        public string local_id { get; set; }
        [DisplayName("Nombre Farmacia")]
        public string local_nombre { get; set; }
        [DisplayName("Comuna")]
        public string comuna_nombre { get; set; }
        [DisplayName("Fk Localidad")]
        public string fk_localidad { get; set; }
        [DisplayName("Nombre Localidad")]
        public string localidad_nombre { get; set; }
        [DisplayName("Dirección")]
        public string local_direccion { get; set; }
        [DisplayName("Hora Apertura")]
        public string funcionamiento_hora_apertura { get; set; }
        [DisplayName("Hora Cierre")]
        public string funcionamiento_hora_cierre { get; set; }
        [DisplayName("Telefono")]
        public string local_telefono { get; set; }
        [DisplayName("Latitud")]
        public string local_lat { get; set; }
        [DisplayName("Longitud")]
        public string local_lng { get; set; }
        [DisplayName("Funcionamiento Día")]
        public string funcionamiento_dia { get; set; }
        [DisplayName("Fk Región")]
        public string fk_region { get; set; }
        [DisplayName("Fk Comuna")]
        public string fk_comuna { get; set; }
    }
}