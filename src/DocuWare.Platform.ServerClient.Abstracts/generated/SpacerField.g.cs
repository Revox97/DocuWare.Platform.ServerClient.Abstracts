using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SpacerField(SDK.SpacerField obj) : ISpacerField
    {
        internal SDK.SpacerField Obj { get; } = obj;
    }
}
