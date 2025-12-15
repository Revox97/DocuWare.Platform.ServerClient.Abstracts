using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class InputFlags(SDK.InputFlags obj) : IInputFlags
    {
        internal SDK.InputFlags Obj { get; } = obj;

        public bool IsEmail
        {
            get => Obj.IsEmail;
            set => Obj.IsEmail = value;
        }
    }
}
