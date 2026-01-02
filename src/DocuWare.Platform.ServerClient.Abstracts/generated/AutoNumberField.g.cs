using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class AutoNumberField(DocuWare.Platform.ServerClient.AutoNumberField obj) : IAutoNumberField
    {
        internal DocuWare.Platform.ServerClient.AutoNumberField Obj { get; } = obj;
    }
}
