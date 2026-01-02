using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class WebFormControl(SDK.WebFormControl obj) : IWebFormControl
    {
        internal SDK.WebFormControl Obj { get; } = obj;
    }
}
