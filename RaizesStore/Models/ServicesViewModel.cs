using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Web;

namespace RaizesStore.Models
{
    public class ServicesViewModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string url_img { get; set; }
    }
}