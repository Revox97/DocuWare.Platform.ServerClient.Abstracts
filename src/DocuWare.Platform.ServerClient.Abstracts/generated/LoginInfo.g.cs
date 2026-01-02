using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class LoginInfo(DocuWare.Platform.ServerClient.LoginInfo obj) : ILoginInfo
    {
        internal DocuWare.Platform.ServerClient.LoginInfo Obj { get; } = obj;

        public string PasswordExpireNotification
        {
            get => Obj.PasswordExpireNotification;
            set => Obj.PasswordExpireNotification = value;
        }

        public DocuWare.Platform.ServerClient.DWProductTypes BookedLicense
        {
            get => Obj.BookedLicense;
            set => Obj.BookedLicense = value;
        }

        public DocuWare.Platform.ServerClient.DWProductTypes ProductType
        {
            get => Obj.ProductType;
            set => Obj.ProductType = value;
        }
    }
}
