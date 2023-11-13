using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RaizesStore.Models
{
    public class BlogViewModel
    {
        public int id { get; set; }
        public string title { get; set; }
        public string subtitle { get; set; }
        public string author { get; set; }
        public string body { get; set; }
        public HttpPostedFileBase img { get; set; }
        public string img_path { get; set; }
    }
}