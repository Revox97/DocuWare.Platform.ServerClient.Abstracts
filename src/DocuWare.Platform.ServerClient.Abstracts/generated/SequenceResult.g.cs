using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SequenceResult(SDK.SequenceResult obj) : ISequenceResult
    {
        internal SDK.SequenceResult Obj { get; } = obj;

        public string NextElement
        {
            get => Obj.NextElement;
            set => Obj.NextElement = value;
        }
    }
}
