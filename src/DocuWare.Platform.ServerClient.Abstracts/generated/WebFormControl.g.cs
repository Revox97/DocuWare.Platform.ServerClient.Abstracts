using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormControl(DocuWare.Platform.ServerClient.WebFormControl obj) : IWebFormControl
    {
        internal DocuWare.Platform.ServerClient.WebFormControl Obj { get; } = obj;
    }
}
