using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class InputFlags(DocuWare.Platform.ServerClient.InputFlags obj) : IInputFlags
    {
        internal DocuWare.Platform.ServerClient.InputFlags Obj { get; } = obj;

        public bool IsEmail
        {
            get => Obj.IsEmail;
            set => Obj.IsEmail = value;
        }
    }
}
