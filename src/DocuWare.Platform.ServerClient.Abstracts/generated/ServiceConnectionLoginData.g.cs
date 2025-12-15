using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnectionLoginData(SDK.ServiceConnectionLoginData obj) : IServiceConnectionLoginData
    {
        internal SDK.ServiceConnectionLoginData Obj { get; } = obj;

        public string Organization
        {
            get => Obj.Organization;
            set => Obj.Organization = value;
        }

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
