namespace QRMaker.Server.Services
{
    public interface IQRCodeService
    {
        string CreateQRCode(string content);
    }
}