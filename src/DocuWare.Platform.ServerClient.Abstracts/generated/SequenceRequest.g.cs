using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SequenceRequest(DocuWare.Platform.ServerClient.SequenceRequest obj) : ISequenceRequest
    {
        internal DocuWare.Platform.ServerClient.SequenceRequest Obj { get; } = obj;

        public string SequenceId
        {
            get => Obj.SequenceId;
            set => Obj.SequenceId = value;
        }
    }
}
