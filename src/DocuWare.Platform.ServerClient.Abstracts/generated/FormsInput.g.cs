using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormsInput(SDK.FormsInput obj) : IFormsInput
    {
        internal SDK.FormsInput Obj { get; } = obj;
    }
}
