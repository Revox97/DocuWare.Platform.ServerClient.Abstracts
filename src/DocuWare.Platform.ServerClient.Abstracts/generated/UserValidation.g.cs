using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UserValidation(SDK.UserValidation obj) : IUserValidation
    {
        internal SDK.UserValidation Obj { get; } = obj;

        public string Password
        {
            get => Obj.Password;
            set => Obj.Password = value;
        }
    }
}
