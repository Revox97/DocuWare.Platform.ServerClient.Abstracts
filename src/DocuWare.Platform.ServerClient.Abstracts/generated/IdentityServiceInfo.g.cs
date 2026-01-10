using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IdentityServiceInfo(DocuWare.Platform.ServerClient.IdentityServiceInfo obj) : IIdentityServiceInfo
    {
        internal DocuWare.Platform.ServerClient.IdentityServiceInfo Obj { get; } = obj;

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
