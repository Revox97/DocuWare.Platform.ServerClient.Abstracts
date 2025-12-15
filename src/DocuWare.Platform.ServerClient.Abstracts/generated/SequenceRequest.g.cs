using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SequenceRequest(SDK.SequenceRequest obj) : ISequenceRequest
    {
        internal SDK.SequenceRequest Obj { get; } = obj;

        public string SequenceId
        {
            get => Obj.SequenceId;
            set => Obj.SequenceId = value;
        }
    }
}
