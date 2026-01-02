using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class UserValidation(DocuWare.Platform.ServerClient.UserValidation obj) : IUserValidation
    {
        internal DocuWare.Platform.ServerClient.UserValidation Obj { get; } = obj;

        public string Password
        {
            get => Obj.Password;
            set => Obj.Password = value;
        }
    }
}
