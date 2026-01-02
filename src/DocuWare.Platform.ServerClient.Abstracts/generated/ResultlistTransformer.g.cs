using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ResultlistTransformer(SDK.ResultlistTransformer obj) : IResultlistTransformer
    {
        internal SDK.ResultlistTransformer Obj { get; } = obj;

        public DocumentsQueryResult ToQueryResult(IDocumentsQueryTableResult resultTable) => new DocumentsQueryResult(Obj.ToQueryResult(resultTable));
    }
}
