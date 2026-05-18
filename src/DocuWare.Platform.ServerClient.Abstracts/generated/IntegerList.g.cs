using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class IntegerList(SDK.IntegerList obj) : IIntegerList
    {
        internal SDK.IntegerList Obj { get; } = obj;

        public List<int> Int
        {
            get => Obj.Int;
            set => Obj.Int = value;
        }
    }
}
