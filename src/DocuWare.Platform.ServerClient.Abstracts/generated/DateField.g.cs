using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DateField(SDK.DateField obj) : IDateField
    {
        internal SDK.DateField Obj { get; } = obj;
    }
}
