using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LoginInfo(SDK.LoginInfo obj) : ILoginInfo
    {
        internal SDK.LoginInfo Obj { get; } = obj;

        public string PasswordExpireNotification
        {
            get => Obj.PasswordExpireNotification;
            set => Obj.PasswordExpireNotification = value;
        }

        public DWProductTypes BookedLicense
        {
            get => (DWProductTypes)Obj.BookedLicense;
            set => Obj.BookedLicense = (DocuWare.Platform.ServerClient.DWProductTypes)value;
        }

        public DWProductTypes ProductType
        {
            get => (DWProductTypes)Obj.ProductType;
            set => Obj.ProductType = (DocuWare.Platform.ServerClient.DWProductTypes)value;
        }
    }
}
