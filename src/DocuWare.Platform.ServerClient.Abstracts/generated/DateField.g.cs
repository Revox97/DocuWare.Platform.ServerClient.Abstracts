using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class DateField(DocuWare.Platform.ServerClient.DateField obj) : IDateField
    {
        internal DocuWare.Platform.ServerClient.DateField Obj { get; } = obj;
    }
}
