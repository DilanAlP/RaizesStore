using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace RaizesStore.Models
{
    public class LoginViewModel
    {
        public int id {get;set;}
        [DisplayName ("Nombre de usuario")]
        public string username { get;set;}
        [DisplayName("Nombre")]
        public string name { get;set;}
        [DisplayName("Apellido paterno")]
        public string flastname { get;set;}
        [DisplayName("Apellido materno")]
        public string slastname { get;set;}
        [DisplayName("Contraseña")]
        public string password { get;set;}
        [DisplayName("Correo electrinico")]
        public string email { get;set; }
        [DisplayName("Telefono")]
        public string phone { get; set; }

    }
}