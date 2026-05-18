using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class RequestConfirmedData(SDK.RequestConfirmedData obj) : IRequestConfirmedData
    {
        internal SDK.RequestConfirmedData Obj { get; } = obj;

        public int DecisionId
        {
            get => Obj.DecisionId;
            set => Obj.DecisionId = value;
        }

        public string Comment
        {
            get => Obj.Comment;
            set => Obj.Comment = value;
        }
    }
}
