using SDK = DocuWare.Platform.ServerClient;

namespace DocuWare.Platform.ServerClient.Abstracts
{
    public class FieldValueExpression(SDK.FieldValueExpression obj) : IFieldValueExpression
    {
        internal SDK.FieldValueExpression Obj { get; } = obj;

        public string FieldName
        {
            get => Obj.FieldName;
            set => Obj.FieldName = value;
        }
    }
}
