using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SignatureField(DocuWare.Platform.ServerClient.SignatureField obj) : ISignatureField
    {
        internal DocuWare.Platform.ServerClient.SignatureField Obj { get; } = obj;
    }
}
