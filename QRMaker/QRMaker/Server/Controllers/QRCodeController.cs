using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using QRMaker.Server.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QRMaker.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class QRCodeController : Controller
    {
        private readonly IQRCodeService service;

        public QRCodeController(IQRCodeService service)
        {
            this.service = service;
        }
        // GET: QRCodeController/Create
        [HttpPost]
        public ActionResult Create(string content)
        {
            string res = service.CreateQRCode(content);
            return Ok(res);
        }
    }
}
