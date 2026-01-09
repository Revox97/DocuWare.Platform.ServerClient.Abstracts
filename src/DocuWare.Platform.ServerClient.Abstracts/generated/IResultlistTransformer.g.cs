using DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public interface IResultlistTransformer{3}
    {

		IDocumentsQueryResult ToQueryResult(IDocumentsQueryTableResult resultTable);
    }
}
