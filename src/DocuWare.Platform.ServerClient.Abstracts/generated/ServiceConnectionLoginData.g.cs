using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

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
            get => (DocuWare.Platform.ServerClient.DWProductTypes?)Obj.LicenseType;
            set => Obj.LicenseType = (DocuWare.Platform.ServerClient.DWProductTypes)value;
        }
    }
}
