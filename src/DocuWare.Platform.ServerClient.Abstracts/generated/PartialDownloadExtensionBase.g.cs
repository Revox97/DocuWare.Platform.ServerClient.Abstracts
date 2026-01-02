using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class PartialDownloadExtensionBase(DocuWare.Platform.ServerClient.PartialDownloadExtensionBase obj) : IPartialDownloadExtensionBase
    {
        internal DocuWare.Platform.ServerClient.PartialDownloadExtensionBase Obj { get; } = obj;
    }
}
