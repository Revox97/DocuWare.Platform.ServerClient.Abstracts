using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormInfoHeader(DocuWare.Platform.ServerClient.FormInfoHeader obj) : IFormInfoHeader
    {
        internal DocuWare.Platform.ServerClient.FormInfoHeader Obj { get; } = obj;
    }
}
