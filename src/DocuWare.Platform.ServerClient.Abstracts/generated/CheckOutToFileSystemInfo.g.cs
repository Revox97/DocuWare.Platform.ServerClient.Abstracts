using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class CheckOutToFileSystemInfo(DocuWare.Platform.ServerClient.CheckOutToFileSystemInfo obj) : ICheckOutToFileSystemInfo
    {
        internal DocuWare.Platform.ServerClient.CheckOutToFileSystemInfo Obj { get; } = obj;
    }
}
