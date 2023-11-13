using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace RaizesStore.Models
{
    public class CorreoViewModel
    {
        [DisplayName("CORREO")]
        public string mail { get; set; }
        [DisplayName("TU NOMBRE")]
        public string name { get; set; }
        [DisplayName("TELEFONO CELULAR")]
        public string phone { get; set; }
        [DisplayName("TITULO DEL CORREO")]
        public string title { get; set; }
        [DisplayName("DANOS TU OPINON")]
        public string body { get; set; }  
    }
}