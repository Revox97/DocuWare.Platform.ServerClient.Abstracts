using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SchemaExtensions(DocuWare.Platform.ServerClient.SchemaExtensions obj) : ISchemaExtensions
    {
        internal DocuWare.Platform.ServerClient.SchemaExtensions Obj { get; } = obj;
    }
}
