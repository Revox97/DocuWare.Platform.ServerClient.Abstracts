using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnectionLoginData(DocuWare.Platform.ServerClient.ServiceConnectionLoginData obj) : IServiceConnectionLoginData
    {
        internal DocuWare.Platform.ServerClient.ServiceConnectionLoginData Obj { get; } = obj;

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
            get => (DocuWare.Platform.ServerClient.DWProductTypes?)Obj.LicenseType;
            set => Obj.LicenseType = (DocuWare.Platform.ServerClient.DWProductTypes)value;
        }
    }
}
