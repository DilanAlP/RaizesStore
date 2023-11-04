using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace RaizesStore.Models
{
    public class CorreoViewModel
    {
        [DisplayName ("CORREO")]
        public string correo { get; set; }
        [DisplayName("TU NOMBRE")]
        public string nombre { get; set; }
        [DisplayName("TELEFONO CELULAR")]
        public string telefono { get; set; }
        [DisplayName("TITULO DEL CORREO")]
        public string asunto { get; set; }
        [DisplayName("DANOS TU OPINON")]
        public string cuerpo { get; set; }  
    }
}