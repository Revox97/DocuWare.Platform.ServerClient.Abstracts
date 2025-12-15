using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ReadStatus(SDK.ReadStatus obj) : IReadStatus
    {
        internal SDK.ReadStatus Obj { get; } = obj;

        public bool IsRead
        {
            get => Obj.IsRead;
            set => Obj.IsRead = value;
        }
    }
}
