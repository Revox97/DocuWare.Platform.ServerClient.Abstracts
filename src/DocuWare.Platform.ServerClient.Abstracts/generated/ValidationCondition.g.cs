using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ValidationCondition(DocuWare.Platform.ServerClient.ValidationCondition obj) : IValidationCondition
    {
        internal DocuWare.Platform.ServerClient.ValidationCondition Obj { get; } = obj;
    }
}
