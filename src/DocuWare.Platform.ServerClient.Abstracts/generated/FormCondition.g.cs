using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FormCondition(DocuWare.Platform.ServerClient.FormCondition obj) : IFormCondition
    {
        internal DocuWare.Platform.ServerClient.FormCondition Obj { get; } = obj;
    }
}
