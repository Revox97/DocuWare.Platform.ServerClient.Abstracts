using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ConfirmedField(SDK.ConfirmedField obj) : IConfirmedField
    {
        internal SDK.ConfirmedField Obj { get; } = obj;

        public int Id
        {
            get => Obj.Id;
            set => Obj.Id = value;
        }
    }
}
