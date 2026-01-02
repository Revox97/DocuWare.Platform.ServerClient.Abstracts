using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SignatureField(SDK.SignatureField obj) : ISignatureField
    {
        internal SDK.SignatureField Obj { get; } = obj;
    }
}
