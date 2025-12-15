using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnectionTokenLoginData(SDK.ServiceConnectionTokenLoginData obj) : IServiceConnectionTokenLoginData
    {
        internal SDK.ServiceConnectionTokenLoginData Obj { get; } = obj;

        public IServiceConnectionTransportData Transport
        {
            get => new ServiceConnectionTransportData(Obj.Transport);
            set => Obj.Transport = ((ServiceConnectionTransportData)value).Obj;
        }

        public DocuWare.Platform.ServerClient.DWProductTypes? LicenseType
        {
            get => Obj.LicenseType;
            set => Obj.LicenseType = value;
        }
    }
}
