using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateSource(DocuWare.Platform.ServerClient.BatchUpdateSource obj) : IBatchUpdateSource
    {
        internal DocuWare.Platform.ServerClient.BatchUpdateSource Obj { get; } = obj;
    }
}
