using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormField(DocuWare.Platform.ServerClient.WebFormField obj) : IWebFormField
    {
        internal DocuWare.Platform.ServerClient.WebFormField Obj { get; } = obj;
    }
}
