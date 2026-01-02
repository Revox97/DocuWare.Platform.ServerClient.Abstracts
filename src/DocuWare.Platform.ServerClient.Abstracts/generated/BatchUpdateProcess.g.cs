using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateProcess(DocuWare.Platform.ServerClient.BatchUpdateProcess obj) : IBatchUpdateProcess
    {
        internal DocuWare.Platform.ServerClient.BatchUpdateProcess Obj { get; } = obj;
    }
}
