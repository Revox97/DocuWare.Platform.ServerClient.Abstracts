using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateSource(SDK.BatchUpdateSource obj) : IBatchUpdateSource
    {
        internal SDK.BatchUpdateSource Obj { get; } = obj;
    }
}
