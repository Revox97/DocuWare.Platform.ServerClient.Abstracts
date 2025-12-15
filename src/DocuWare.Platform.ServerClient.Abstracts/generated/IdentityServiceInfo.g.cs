using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IdentityServiceInfo(SDK.IdentityServiceInfo obj) : IIdentityServiceInfo
    {
        internal SDK.IdentityServiceInfo Obj { get; } = obj;

		public string IdentityServiceUrl
		{
			get => Obj.IdentityServiceUrl;
			set => Obj.IdentityServiceUrl = value;
		}

		public bool RefreshTokenSupported
		{
			get => Obj.RefreshTokenSupported;
			set => Obj.RefreshTokenSupported = value;
		}
    }
}
