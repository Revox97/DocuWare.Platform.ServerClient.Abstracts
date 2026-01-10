using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnectionTokenLoginData(DocuWare.Platform.ServerClient.ServiceConnectionTokenLoginData obj) : IServiceConnectionTokenLoginData
    {
        internal DocuWare.Platform.ServerClient.ServiceConnectionTokenLoginData Obj { get; } = obj;

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
