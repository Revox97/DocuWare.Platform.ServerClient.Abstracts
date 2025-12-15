using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ServiceConnectionLicenseBoundData(SDK.ServiceConnectionLicenseBoundData obj) : IServiceConnectionLicenseBoundData
    {
        internal SDK.ServiceConnectionLicenseBoundData Obj { get; } = obj;

		public IServiceConnectionTransportData Transport
		{
			get => new ServiceConnectionTransportData(Obj.Transport);
			set => Obj.Transport = ((ServiceConnectionTransportData)value).Obj;
		}

		public DWProductTypes? LicenseType
		{
			get => Obj.LicenseType;
			set => Obj.LicenseType = value;
		}
    }
}
