using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Newtonsoft.Json;

namespace Negocio
{
    public class AdministradorFarmacia
    {

        public List<Farmacia> ObtenerTodos()
        {
            try
            {
                //  Url de la API de las farmacias de turno.
                string apiUrl = "https://farmanet.minsal.cl/maps/index.php/ws/getLocalesTurnos";
                WebClient http = new WebClient();

                http.Headers.Add(HttpRequestHeader.Accept, "application/json");

                //  Obteniendo el listado de farmacias.
                var res = http.DownloadString(apiUrl);

                //  Transformando el listado a la clase de Farmacia en una lista.
                var farmaciasTurno = JsonConvert.DeserializeObject<List<Farmacia>>(res);

                return farmaciasTurno;

            }
            catch (Exception)
            {
                return null;
            }
            
        }     

        public Farmacia ObtenerFarmacia(string id)
        {
            List<Farmacia> lista = ObtenerTodos();
            Farmacia farmacia = new Farmacia();

            foreach (var item in lista)
            {
                if (item.local_id.Equals(id))
                {
                    return item;
                }
            }

            return null;
        }

        public List<Farmacia> BuscarPorComuna(string comuna)
        {
            comuna = comuna.ToUpper();
            List<Farmacia> lista = ObtenerTodos();
            List<Farmacia> listaBusqueda = new List<Farmacia>();

            foreach (var item in lista)
            {
                if (item.comuna_nombre.Equals(comuna))
                {
                    listaBusqueda.Add(item);
                }
            }

            return listaBusqueda;
        }

       


       
    }
}
