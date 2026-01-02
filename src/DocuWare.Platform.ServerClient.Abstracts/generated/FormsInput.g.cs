using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormsInput(DocuWare.Platform.ServerClient.FormsInput obj) : IFormsInput
    {
        internal DocuWare.Platform.ServerClient.FormsInput Obj { get; } = obj;
    }
}
