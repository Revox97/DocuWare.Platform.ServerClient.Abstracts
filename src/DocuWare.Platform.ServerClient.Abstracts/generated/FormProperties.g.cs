using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormProperties(DocuWare.Platform.ServerClient.FormProperties obj) : IFormProperties
    {
        internal DocuWare.Platform.ServerClient.FormProperties Obj { get; } = obj;
    }
}
