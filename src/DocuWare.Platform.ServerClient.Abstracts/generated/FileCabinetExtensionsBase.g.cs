using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileCabinetExtensionsBase(DocuWare.Platform.ServerClient.FileCabinetExtensionsBase obj) : IFileCabinetExtensionsBase
    {
        internal DocuWare.Platform.ServerClient.FileCabinetExtensionsBase Obj { get; } = obj;
    }
}
