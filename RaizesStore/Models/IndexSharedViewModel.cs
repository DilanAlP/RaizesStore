using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaizesStore.Models
{
    public class IndexSharedViewModel
    {
        public LoginViewModel login { get; set; }
        public CorreoViewModel mail { get; set; }
        public List<ServicesViewModel> services { get; set; }  
    }
}