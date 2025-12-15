using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CheckOutToFileSystemInfo(SDK.CheckOutToFileSystemInfo obj) : ICheckOutToFileSystemInfo
    {
        internal SDK.CheckOutToFileSystemInfo Obj { get; } = obj;
    }
}
