using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FileNameExtensions(DocuWare.Platform.ServerClient.FileNameExtensions obj) : IFileNameExtensions
    {
        internal DocuWare.Platform.ServerClient.FileNameExtensions Obj { get; } = obj;
    }
}
