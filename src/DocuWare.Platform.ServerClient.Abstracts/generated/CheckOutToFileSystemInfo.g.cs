using SDK = DocuWare.Platform.ServerClient;
using DocuWare.Platform.ServerClient.Abstracts.Content;
using DocuWare.Platform.ServerClient.Abstracts.Policy.CircuitBreaker;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Resilience;
using DocuWare.Platform.ServerClient.Abstracts.Policy.Retry;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CheckOutToFileSystemInfo(SDK.CheckOutToFileSystemInfo obj) : ICheckOutToFileSystemInfo
    {
        internal SDK.CheckOutToFileSystemInfo Obj { get; } = obj;
    }
}
