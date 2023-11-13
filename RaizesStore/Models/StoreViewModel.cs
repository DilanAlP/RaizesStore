using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI.WebControls;

namespace RaizesStore.Models
{
    public class StoreViewModel
    {
        public int id { get; set; }
        public string name { get; set; }    
        public string description { get; set; } 
        public int stock {get; set; }
        public string price { get; set;}
        public HttpPostedFileBase img { get; set; }
        public string img_path { get; set; }

    }
}