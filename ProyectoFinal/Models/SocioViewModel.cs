using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ProyectoFinal.Models
{
    public class SocioViewModel
    {
        public int SocioID { get; set; }

        public string Nombre { get; set; }


        public string Apellido { get; set; }


        public string Cedula { get; set; }

  
        public  HttpPostedFileBase Foto { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Sexo { get; set; }

        public string Edad { get; set; }
        [DataType(DataType.Date)]
     
        public DateTime FechaNacimiento { get; set; }

        public string Afiliados { get; set; }

        public string Membresia { get; set; }

        public string LugarTrabajo { get; set; }

        public string DireccionOficina { get; set; }

        public string TelefonoOficina { get; set; }

        public string EstadoMembresia { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaIngreso { get; set; }

        [DataType(DataType.Date)]
        public DateTime FechaSalida { get; set; }
    }
}