using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ResultlistTransformer(SDK.ResultlistTransformer obj) : IResultlistTransformer
    {
        internal SDK.ResultlistTransformer Obj { get; } = obj;

        public IDocumentsQueryResult ToQueryResult(IDocumentsQueryTableResult resultTable) => new DocumentsQueryResult(Obj.ToQueryResult(resultTable));

    }
}
