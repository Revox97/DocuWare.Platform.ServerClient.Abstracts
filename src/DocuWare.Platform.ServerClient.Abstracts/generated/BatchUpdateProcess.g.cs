using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateProcess(SDK.BatchUpdateProcess obj) : IBatchUpdateProcess
    {
        internal SDK.BatchUpdateProcess Obj { get; } = obj;
    }
}
