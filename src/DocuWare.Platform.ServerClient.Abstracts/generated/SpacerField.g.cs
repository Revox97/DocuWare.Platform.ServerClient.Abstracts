using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SpacerField(DocuWare.Platform.ServerClient.SpacerField obj) : ISpacerField
    {
        internal DocuWare.Platform.ServerClient.SpacerField Obj { get; } = obj;
    }
}
