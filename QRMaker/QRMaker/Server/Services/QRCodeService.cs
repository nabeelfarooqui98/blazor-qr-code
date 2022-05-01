using QRCoder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QRMaker.Server.Services
{
    public class QRCodeService : IQRCodeService
    {
        public string CreateQRCode(string content)
        {
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qrCodeData = qrGenerator.CreateQrCode("The text which should be encoded.", QRCodeGenerator.ECCLevel.Q);
            Base64QRCode qrCode = new Base64QRCode(qrCodeData);
            string qrCodeImageAsBase64 = qrCode.GetGraphic(20);
            return "hello";
        }
    }
}
