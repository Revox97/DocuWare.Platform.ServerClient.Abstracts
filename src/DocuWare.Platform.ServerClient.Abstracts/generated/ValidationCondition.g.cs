using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class ValidationCondition(SDK.ValidationCondition obj) : IValidationCondition
    {
        internal SDK.ValidationCondition Obj { get; } = obj;
    }
}
