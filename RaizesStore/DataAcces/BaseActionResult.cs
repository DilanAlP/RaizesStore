using RaizesStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RaizesStore.DataAcces
{
    public class BaseActionResult : Controller
    {
        protected List<ServicesViewModel> _services;

        public BaseActionResult()
        {
            using (RaizesEntities db = new RaizesEntities()) {
                this._services = (from d in db.Services
                                  select new ServicesViewModel
                                  {
                                      id = d.id,
                                      title = d.title,
                                      type = d.kind,
                                      url_img = d.img,
                                      description = d.description
                                  }).Distinct().ToList();
            }
        }
    }
}