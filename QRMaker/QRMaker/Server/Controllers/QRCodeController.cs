using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QRMaker.Server.Controllers
{
    public class QRCodeController : Controller
    {
        // GET: QRCodeController/Create
        [HttpPost]
        public ActionResult Create(string content)
        {
            return View();
        }
    }
}
