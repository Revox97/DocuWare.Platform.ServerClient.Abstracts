using SDK = DocuWare.Platform.ServerClient;

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
			get => new WProductTypes(Obj.BookedLicense);
			set => Obj.BookedLicense = ((WProductTypes)value).Obj;
		}

		public DWProductTypes ProductType
		{
			get => new WProductTypes(Obj.ProductType);
			set => Obj.ProductType = ((WProductTypes)value).Obj;
		}
    }
}
