using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class EasyFileUploadExtensionsBase(DocuWare.Platform.ServerClient.EasyFileUploadExtensionsBase obj) : IEasyFileUploadExtensionsBase
    {
        internal DocuWare.Platform.ServerClient.EasyFileUploadExtensionsBase Obj { get; } = obj;
    }
}
