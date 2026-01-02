using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldValueExpression(DocuWare.Platform.ServerClient.FieldValueExpression obj) : IFieldValueExpression
    {
        internal DocuWare.Platform.ServerClient.FieldValueExpression Obj { get; } = obj;

        public string FieldName
        {
            get => Obj.FieldName;
            set => Obj.FieldName = value;
        }
    }
}
