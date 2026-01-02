using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SequenceResult(DocuWare.Platform.ServerClient.SequenceResult obj) : ISequenceResult
    {
        internal DocuWare.Platform.ServerClient.SequenceResult Obj { get; } = obj;

        public string NextElement
        {
            get => Obj.NextElement;
            set => Obj.NextElement = value;
        }
    }
}
