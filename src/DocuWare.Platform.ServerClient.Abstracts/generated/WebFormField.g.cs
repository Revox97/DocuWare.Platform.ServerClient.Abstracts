using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormField(SDK.WebFormField obj) : IWebFormField
    {
        internal SDK.WebFormField Obj { get; } = obj;
    }
}
