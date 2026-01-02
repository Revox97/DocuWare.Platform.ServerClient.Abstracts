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
