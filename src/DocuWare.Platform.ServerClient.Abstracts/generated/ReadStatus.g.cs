using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ReadStatus(DocuWare.Platform.ServerClient.ReadStatus obj) : IReadStatus
    {
        internal DocuWare.Platform.ServerClient.ReadStatus Obj { get; } = obj;

        public bool IsRead
        {
            get => Obj.IsRead;
            set => Obj.IsRead = value;
        }
    }
}
