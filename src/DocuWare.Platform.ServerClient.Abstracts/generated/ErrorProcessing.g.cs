using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ErrorProcessing(SDK.ErrorProcessing obj) : IErrorProcessing
    {
        internal SDK.ErrorProcessing Obj { get; } = obj;
    }
}
