using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class SchemaExtensions(SDK.SchemaExtensions obj) : ISchemaExtensions
    {
        internal SDK.SchemaExtensions Obj { get; } = obj;
    }
}
