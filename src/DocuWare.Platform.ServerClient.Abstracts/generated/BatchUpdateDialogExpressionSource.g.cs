using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class BatchUpdateDialogExpressionSource(SDK.BatchUpdateDialogExpressionSource obj) : IBatchUpdateDialogExpressionSource
    {
        internal SDK.BatchUpdateDialogExpressionSource Obj { get; } = obj;
    }
}
