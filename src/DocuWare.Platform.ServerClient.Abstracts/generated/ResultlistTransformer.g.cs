using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ResultlistTransformer(DocuWare.Platform.ServerClient.ResultlistTransformer obj) : IResultlistTransformer
    {
        internal DocuWare.Platform.ServerClient.ResultlistTransformer Obj { get; } = obj;

        public IDocumentsQueryResult ToQueryResult(IDocumentsQueryTableResult resultTable) => new DocumentsQueryResult(Obj.ToQueryResult(((DocumentsQueryTableResult)resultTable).Obj));
    }
}
