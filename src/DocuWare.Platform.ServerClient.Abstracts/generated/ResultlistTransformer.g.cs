using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ResultlistTransformer(SDK.ResultlistTransformer obj) : IResultlistTransformer
    {
        internal SDK.ResultlistTransformer Obj { get; } = obj;

        public IDocumentsQueryResult ToQueryResult(IDocumentsQueryTableResult resultTable) => new DocumentsQueryResult(Obj.ToQueryResult(((DocumentsQueryTableResult)resultTable).Obj));
    }
}
